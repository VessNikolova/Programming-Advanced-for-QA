
int number = int.Parse(Console.ReadLine());

Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();

for (int i = 0; i < number; i++)
{
    string student = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!grades.ContainsKey(student))
    {
        grades.Add(student, new List<double>());
        grades[student].Add(grade);
    }
    else
    {
        grades[student].Add(grade);
    }
}

 
