

namespace Students
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while(input != "end")
            {
                string[] commands = input.Split(" ");
                string firstName = commands[0];
                string lastName = commands[1];
                int age = int.Parse(commands[2]);
                string homeTown = commands[3];

                Student student = new Student(firstName, lastName, age, homeTown);

                students.Add(student);

                input = Console.ReadLine();
            }

            string town = Console.ReadLine();

            students
                .Where(s => s.HomeTown == town)
                .ToList()
                .ForEach (s => Console.WriteLine($"{s.FirstName} {s.LastName} is {s.Age} years old.")) ;



        }
    }
}