
namespace Students
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            students
                .OrderByDescending(s => s.Grade)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}: {s.Grade:F2}"));
        }
    }
}
