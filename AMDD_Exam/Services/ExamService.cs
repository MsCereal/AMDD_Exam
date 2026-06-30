using AMDD_Exam.Models;
using System.Collections.Generic;
using System.Linq;

namespace AMDD_Exam.Services
{
    public class ExamService
    {
        public List<ExamQuestion> GetQuestions() => new List<ExamQuestion>
        {
            // ════════════════════════════════════════════════════════════
            // PART A — C# FUNDAMENTALS (MCQ)
            // ════════════════════════════════════════════════════════════
            new ExamQuestion { Id=1, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="Which keyword is used to declare a class in C#?",
                Choices=new List<string>{ "object", "class", "new", "public" },
                CorrectIndex=1 },

            new ExamQuestion { Id=2, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="What will be the output of this code?\n\nint x = 10;\nint y = 3;\nConsole.WriteLine(x % y);",
                Choices=new List<string>{ "1", "3", "0", "10" },
                CorrectIndex=0 },

            new ExamQuestion { Id=3, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="Which collection type in C# automatically resizes as items are added?",
                Choices=new List<string>{ "Array", "List<T>", "Queue", "Tuple" },
                CorrectIndex=1 },

            new ExamQuestion { Id=4, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="Which keyword is used to catch and handle exceptions in C#?",
                Choices=new List<string>{ "if", "catch", "switch", "lock" },
                CorrectIndex=1 },

            new ExamQuestion { Id=5, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="What is the purpose of an interface in C#?",
                Choices=new List<string>{
                    "Store data in memory",
                    "Define a contract that classes must implement",
                    "Create database tables",
                    "Declare variables globally" },
                CorrectIndex=1 },

            new ExamQuestion { Id=6, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="What is the output of this code?\n\nstring name = \"Chelsea\";\nConsole.WriteLine(name.Length);",
                Choices=new List<string>{ "6", "7", "8", "Error" },
                CorrectIndex=2 },

            new ExamQuestion { Id=7, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="What is the output of this C# snippet?\n\nint x = 5;\nint y = x++;\nConsole.WriteLine(y);",
                Choices=new List<string>{ "6", "5", "4", "Compilation error" },
                CorrectIndex=1 },

            new ExamQuestion { Id=8, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="What is the output of this C# snippet?\n\nint a = 10;\nint b = 20;\nConsole.WriteLine(a + b);",
                Choices=new List<string>{ "10", "20", "1020", "30" },
                CorrectIndex=3 },

            new ExamQuestion { Id=9, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="Which access modifier makes a class member accessible only within its own class?",
                Choices=new List<string>{ "public", "protected", "private", "internal" },
                CorrectIndex=2 },

            new ExamQuestion { Id=10, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="What does OOP stand for?",
                Choices=new List<string>{
                    "Object-Oriented Programming",
                    "Open-Oriented Protocol",
                    "Object-Optimized Processing",
                    "Output-Oriented Procedure" },
                CorrectIndex=0 },

            new ExamQuestion { Id=11, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="Which principle of OOP means that a child class can be used wherever a parent class is expected?",
                Choices=new List<string>{ "Encapsulation", "Abstraction", "Polymorphism", "Inheritance" },
                CorrectIndex=3 },

            new ExamQuestion { Id=12, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="What is the correct way to declare a nullable integer in C#?",
                Choices=new List<string>{ "int? x;", "nullable int x;", "int x = null;", "optional int x;" },
                CorrectIndex=0 },

            new ExamQuestion { Id=13, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="What is the primary purpose of Git in software development?",
                Choices=new List<string>{
                    "To edit images and design assets",
                    "To track changes in source code and collaborate with other developers",
                    "To compile C# applications",
                    "To manage Windows updates" },
                CorrectIndex=1 },

            new ExamQuestion { Id=14, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="Which HTTP method is commonly used to CREATE a new resource via a REST API?",
                Choices=new List<string>{ "GET", "DELETE", "PUT", "POST" },
                CorrectIndex=3 },

            new ExamQuestion { Id=15, Section="CSharp", Type="mcq", Dimension=Dimension.Dev,
                Text="In ASP.NET Core MVC, what is the role of the Controller?",
                Choices=new List<string>{
                    "It stores the database connection string",
                    "It defines the HTML markup and page styling",
                    "It handles HTTP requests, processes logic, and returns a response or view",
                    "It is only used for authentication" },
                CorrectIndex=2 },

            // ════════════════════════════════════════════════════════════
            // PART B — SQL FUNDAMENTALS (MCQ)
            // ════════════════════════════════════════════════════════════
            new ExamQuestion { Id=16, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="Which SQL statement retrieves ALL records from the Employees table?",
                Choices=new List<string>{
                    "SELECT * FROM Employees;",
                    "GET Employees;",
                    "SHOW Employees;",
                    "DISPLAY Employees;" },
                CorrectIndex=0 },

            new ExamQuestion { Id=17, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="Which query returns employees earning more than 50,000?\n\nTable: Employees (EmployeeID, Name, Department, Salary)",
                Choices=new List<string>{
                    "SELECT * FROM Employees WHERE Salary > 50000;",
                    "SELECT Salary > 50000;",
                    "GET Employees Salary > 50000;",
                    "SELECT FROM Employees;" },
                CorrectIndex=0 },

            new ExamQuestion { Id=18, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="Which SQL clause is used to combine matching rows from two tables?",
                Choices=new List<string>{ "UNION", "JOIN", "GROUP BY", "ORDER BY" },
                CorrectIndex=1 },

            new ExamQuestion { Id=19, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="Which SQL aggregate function counts the number of records?",
                Choices=new List<string>{ "SUM()", "COUNT()", "AVG()", "MAX()" },
                CorrectIndex=1 },

            new ExamQuestion { Id=20, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="Which query correctly sorts employees by salary from HIGHEST to LOWEST?",
                Choices=new List<string>{
                    "ORDER Salary DESC",
                    "SORT Salary DESC",
                    "SELECT * FROM Employees ORDER BY Salary DESC;",
                    "SELECT Salary DESC;" },
                CorrectIndex=2 },

            new ExamQuestion { Id=21, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="Which SQL statement is used to MODIFY existing records in a table?",
                Choices=new List<string>{ "INSERT", "CREATE", "DELETE", "UPDATE" },
                CorrectIndex=3 },

            new ExamQuestion { Id=22, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="In SQL, what is the difference between WHERE and HAVING?",
                Choices=new List<string>{
                    "They are identical; HAVING is just an alias for WHERE",
                    "WHERE filters rows before grouping; HAVING filters after GROUP BY aggregation",
                    "HAVING works only on text columns; WHERE works only on numeric columns",
                    "WHERE is for SELECT only; HAVING is for INSERT" },
                CorrectIndex=1 },

            new ExamQuestion { Id=23, Section="SQL", Type="mcq", Dimension=Dimension.Dev,
                Text="Which SQL keyword removes duplicate rows from a result set?",
                Choices=new List<string>{ "UNIQUE", "DISTINCT", "FILTER", "REMOVE" },
                CorrectIndex=1 },

            // ════════════════════════════════════════════════════════════
            // PART C — SECURITY & IT SCENARIOS
            // ════════════════════════════════════════════════════════════
            new ExamQuestion { Id=24, Section="Security", Type="mcq", Dimension=Dimension.Support,
                Text="A user receives an email asking for their banking application password, claiming it is from IT. What should the user do?",
                Choices=new List<string>{
                    "Reply immediately with their password",
                    "Share the password only if the email looks official",
                    "Report the email as phishing and do not click any links",
                    "Forward it to everyone in the office" },
                CorrectIndex=2 },

            new ExamQuestion { Id=25, Section="Security", Type="mcq", Dimension=Dimension.Support,
                Text="What is Multi-Factor Authentication (MFA)?",
                Choices=new List<string>{
                    "Using two different passwords",
                    "A type of antivirus software",
                    "Verifying identity using two or more authentication factors (e.g. password + OTP)",
                    "Encrypting files on a hard drive" },
                CorrectIndex=2 },

            new ExamQuestion { Id=26, Section="Security", Type="mcq", Dimension=Dimension.Support,
                Text="Which of the following is the STRONGEST password?",
                Choices=new List<string>{ "Password123", "Chelsea2026", "Welcome1", "T#8vP!9x@Lm2" },
                CorrectIndex=3 },

            // ════════════════════════════════════════════════════════════
            // PART D — ATTITUDE / BEHAVIORAL
            // ════════════════════════════════════════════════════════════
            new ExamQuestion { Id=27, Section="Attitude", Type="mcq", Dimension=Dimension.Attitude,
                Text="A task is assigned with a 2-hour deadline but the requirements are unclear. What do you do?",
                Choices=new List<string>{
                    "Start working based on your own assumptions",
                    "Immediately ask your team lead to clarify key points, then work as efficiently as possible",
                    "Ignore the task since unclear requirements are not your problem",
                    "Wait until the requirements are 100% clear even if the deadline passes" },
                CorrectIndex=1 },

            new ExamQuestion { Id=28, Section="Attitude", Type="mcq", Dimension=Dimension.Attitude,
                Text="A colleague points out a mistake in your code during a code review. How do you respond?",
                Choices=new List<string>{
                    "Defend your code and argue it is correct",
                    "Thank them, understand the issue, fix it, and learn from the feedback",
                    "Feel offended and stop attending future reviews",
                    "Blame the requirements document" },
                CorrectIndex=1 },

            new ExamQuestion { Id=29, Section="Attitude", Type="mcq", Dimension=Dimension.Attitude,
                Text="You discover a critical bug in production on Friday at 4:30 PM. What is your action?",
                Choices=new List<string>{
                    "Log off and deal with it Monday",
                    "Immediately inform your team lead, assess the impact, and collaborate on a fix or rollback",
                    "Hide the bug and hope no one notices",
                    "Send an email and wait for a reply next week" },
                CorrectIndex=1 },

            new ExamQuestion { Id=30, Section="Attitude", Type="mcq", Dimension=Dimension.Attitude,
                Text="Your team is assigned a project using a technology stack you have never used. What is your approach?",
                Choices=new List<string>{
                    "Refuse the project until given a familiar stack",
                    "Proactively study the new stack, ask for guidance, and apply it step by step",
                    "Copy-paste code from the internet without understanding it",
                    "Tell the manager it is impossible" },
                CorrectIndex=1 },

            new ExamQuestion { Id=31, Section="Attitude", Type="mcq", Dimension=Dimension.Attitude,
                Text="A feature works perfectly on your local machine but fails in production. What is your FIRST action?",
                Choices=new List<string>{
                    "Rewrite the whole application from scratch",
                    "Restart the production server repeatedly",
                    "Review logs, compare environment configurations, and reproduce the issue before applying a fix",
                    "Roll back all recent code without any investigation" },
                CorrectIndex=2 },

            // ════════════════════════════════════════════════════════════
            // PART E — PRACTICAL CODING CHALLENGES
            // ════════════════════════════════════════════════════════════
            new ExamQuestion { Id=32, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="C# Coding: Write a method that accepts an integer and returns true if the number is EVEN, otherwise false.",
                CodingPrompt="Example:\n  Input:  4  → Output: true\n  Input:  7  → Output: false\n\nWrite in C# (or pseudocode if needed).",
                CodingLanguageHint="C#" },

            new ExamQuestion { Id=33, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="C# Coding: Write a function that accepts an integer array and returns the SUM of all EVEN numbers.",
                CodingPrompt="Example:\n  Input:  [1, 2, 3, 4, 5, 6]\n  Output: 12\n\nUse C#, Java, Python, or pseudocode.",
                CodingLanguageHint="C#, Java, Python, or pseudocode" },

            new ExamQuestion { Id=34, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="SQL Query: Write a query that displays the Name of employees whose Department is 'IT'.\n\nTable: Employees (EmployeeID, Name, Department, Salary)",
                CodingPrompt="Expected:\n  SELECT Name FROM Employees WHERE Department = 'IT';",
                CodingLanguageHint="SQL" },

            new ExamQuestion { Id=35, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="SQL JOIN: Write a query to display CustomerName, OrderID, and OrderDate.\n\nTables:\n  Customers (CustomerID, CustomerName)\n  Orders    (OrderID, CustomerID, OrderDate)",
                CodingPrompt="Use the appropriate JOIN to combine both tables.\nExpected output columns: CustomerName, OrderID, OrderDate",
                CodingLanguageHint="SQL" },

            new ExamQuestion { Id=36, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="Debugging: What is wrong with this code? Explain the error and write the corrected version.\n\nint number = \"10\";\nConsole.WriteLine(number);",
                CodingPrompt="Identify the bug, explain why it fails, and write the corrected code.",
                CodingLanguageHint="C# — explanation + corrected code" },

            new ExamQuestion { Id=37, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="Debugging: This loop never terminates. Explain why and write the corrected version.\n\nfor (int i = 0; i <= 5; i--)\n{\n    Console.WriteLine(i);\n}",
                CodingPrompt="Why does this code never terminate?\nExplain the bug AND write the corrected loop.",
                CodingLanguageHint="C# — explanation + corrected code" },

            new ExamQuestion { Id=38, Section="Coding", Type="code", Dimension=Dimension.Dev,
                Text="SQL: Write a query to return all reports generated TODAY for the 'SAN FERNANDO LA UNION' branch.\n\nTable: ATM_Reports (TID, Branch, ReportDate, GeneratedBy, Status)",
                CodingPrompt="Use CAST(GETDATE() AS DATE) or equivalent for today's date.",
                CodingLanguageHint="SQL" },

            // ════════════════════════════════════════════════════════════
            // PART F — ESSAY
            // ════════════════════════════════════════════════════════════
            new ExamQuestion { Id=39, Section="Essay", Type="essay", Dimension=Dimension.Dev,
                Text="Describe your technical skills and experience.",
                EssayBullets="• Programming languages you know (C#, Java, Python, etc.)\n• Frameworks and tools (ASP.NET, Git, REST APIs, etc.)\n• Databases you have worked with\n• Where you learned these skills\n• A project where you applied them" },

            new ExamQuestion { Id=40, Section="Essay", Type="essay", Dimension=Dimension.Dev,
                Text="What software project are you most proud of? Describe it in detail.",
                EssayBullets="• Purpose of the project\n• Technologies used\n• Your specific contribution\n• Biggest challenge you faced\n• What you would improve in the future" },
        };

        // ── Evaluate & Classify ──────────────────────────────────────────
        public ExamSubmission Evaluate(ExamSubmitViewModel vm)
        {
            var questions = GetQuestions().ToDictionary(q => q.Id);

            int suppScore = 0, suppMax = 0;
            int devScore  = 0, devMax  = 0;
            int attScore  = 0, attMax  = 0;
            int codingAttempted = 0, codingTotal = 0;

            foreach (var q in questions.Values)
            {
                if (q.Type == "code")
                {
                    codingTotal++;
                    if (vm.OpenAnswers.TryGetValue(q.Id, out string code)
                        && !string.IsNullOrWhiteSpace(code))
                        codingAttempted++;
                    continue;
                }
                if (q.Type == "essay") continue;

                bool correct = vm.Answers.TryGetValue(q.Id, out int ans) && ans == q.CorrectIndex;
                switch (q.Dimension)
                {
                    case Dimension.Support: suppMax++;  if (correct) suppScore++; break;
                    case Dimension.Dev:     devMax++;   if (correct) devScore++;  break;
                    case Dimension.Attitude:attMax++;   if (correct) attScore++;  break;
                }
            }

            double suppPct = suppMax  > 0 ? (double)suppScore / suppMax  : 0;
            double devPct  = devMax   > 0 ? (double)devScore  / devMax   : 0;
            double attPct  = attMax   > 0 ? (double)attScore  / attMax   : 0;
            double codPct  = codingTotal > 0 ? (double)codingAttempted / codingTotal : 0;

            ResultClassification classification;
            if (attPct < 0.60)
                classification = ResultClassification.NotAFit;
            else if (devPct >= 0.60 && codPct >= 0.50)
                classification = ResultClassification.Developer;
            else if (suppPct >= 0.60)
                classification = ResultClassification.Support;
            else if (devPct >= 0.60)
                classification = suppPct >= 0.40
                    ? ResultClassification.Support
                    : ResultClassification.NotAFit;
            else
                classification = ResultClassification.NotAFit;

            string remarks = classification == ResultClassification.Developer
                ? "Strong C# and SQL technical knowledge, positive work attitude, and active participation in coding challenges. Candidate shows clear potential as a Software Developer for AMDD."
                : classification == ResultClassification.Support
                    ? "Good understanding of security, IT processes, and work attitude. Candidate is suited for an IT Support role within the team."
                    : "Results do not sufficiently align with either a Developer or IT Support profile at this time. Encourage the applicant to build their skills and apply again.";

            return new ExamSubmission
            {
                ApplicantName   = vm.ApplicantName,
                Answers         = vm.Answers,
                OpenAnswers     = vm.OpenAnswers,
                SelfRatings     = vm.SelfRatings,
                SupportScore    = suppScore,
                SupportMax      = suppMax,
                DevScore        = devScore,
                DevMax          = devMax,
                AttitudeScore   = attScore,
                AttitudeMax     = attMax,
                CodingAttempted = codingAttempted,
                CodingTotal     = codingTotal,
                Classification  = classification,
                Remarks         = remarks
            };
        }
    }
}
