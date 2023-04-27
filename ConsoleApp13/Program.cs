namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();

            exams.Add(new Exam { Subject = "C# Programming", ExamDuration = TimeSpan.FromHours(1), StartDate = new DateTime(2023, 4, 15, 9, 0, 0) });
            exams.Add(new Exam { Subject = "Database Design", ExamDuration = TimeSpan.FromHours(2), StartDate = new DateTime(2023, 5, 10, 14, 0, 0) });
            exams.Add(new Exam { Subject = "Web Development", ExamDuration = TimeSpan.FromHours(3), StartDate = new DateTime(2023, 7, 5, 10, 0, 0) });

            exams.FindAll(exams => exams.ExamDuration > TimeSpan.FromHours(2)).ForEach(exams => Console.WriteLine(exams));

            exams.FindAll(exams => exams.StartDate >= DateTime.Today.AddDays(-7)).ForEach(exams => Console.WriteLine(exams.Subject));

            exams.FindAll(exams => exams.StartDate >= DateTime.Now && exams.EndDate > DateTime.Now).ForEach(exams => Console.WriteLine(exams.Subject));


        }
    }
}