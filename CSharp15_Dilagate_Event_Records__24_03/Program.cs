namespace CSharp15_Dilagate_Event_Records__24_03
{
    public class StudentGrades
    {
        public string Name { get; }
        public int[] Grades { get; }

        public StudentGrades(string name, int[] grades)
        {
            Name = name;
            Grades = grades;
        }

        public int GetMaxGrade()
        {
            return Grades.Max();
        }

        public double GetAverageGrade()
        {
            return Grades.Average();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            StudentGrades[] students = {
            new StudentGrades("John", new int[] { 85, 90, 92 }),
            new StudentGrades("Alice", new int[] { 78, 88, 90 }),
            new StudentGrades("Emma", new int[] { 95, 92, 98 })
        };

           
            StudentGrades studentWithMaxGrade = students.OrderByDescending(s => s.GetMaxGrade()).FirstOrDefault();
            Console.WriteLine($"Student with maximum grade: {studentWithMaxGrade.Name}");

            
            double totalAverageGrade = students.Select(s => s.GetAverageGrade()).Average();
            Console.WriteLine($"Average grade for all students: {totalAverageGrade}");
        }
    }
}
