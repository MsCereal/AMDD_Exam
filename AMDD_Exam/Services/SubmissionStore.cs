using AMDD_Exam.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace AMDD_Exam.Services
{
    /// <summary>
    /// Persists submissions to a JSON file so they survive app restarts.
    /// </summary>
    public class SubmissionStore
    {
        private readonly string _filePath;
        private readonly object _lock = new object();
        private List<ExamSubmission> _cache;

        public SubmissionStore()
        {
            // On Render, /app is the working directory — writable
            var dir = Path.Combine(AppContext.BaseDirectory, "data");
            Directory.CreateDirectory(dir);
            _filePath = Path.Combine(dir, "submissions.json");
            _cache = Load();
        }

        public void Save(ExamSubmission submission)
        {
            lock (_lock)
            {
                // Replace if exists, otherwise add
                var existing = _cache.FindIndex(s => s.Id == submission.Id);
                if (existing >= 0) _cache[existing] = submission;
                else _cache.Add(submission);
                Persist();
            }
        }

        public List<ExamSubmission> GetAll()
        {
            lock (_lock)
                return _cache.OrderByDescending(s => s.SubmittedAt).ToList();
        }

        public ExamSubmission GetById(Guid id)
        {
            lock (_lock)
                return _cache.FirstOrDefault(s => s.Id == id);
        }

        private List<ExamSubmission> Load()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    var json = File.ReadAllText(_filePath);
                    return JsonSerializer.Deserialize<List<ExamSubmission>>(json)
                           ?? new List<ExamSubmission>();
                }
            }
            catch { /* corrupt file — start fresh */ }
            return new List<ExamSubmission>();
        }

        private void Persist()
        {
            var json = JsonSerializer.Serialize(_cache,
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}
