namespace CSharp15_Dilagate_Event_Records__24_03
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }

    public static class PersonExtensions
    {
        public static Person FindOldest(this Person[] people)
        {
            return people.OrderByDescending(p => p.Age).FirstOrDefault();
        }

        public static Person FindYoungest(this Person[] people)
        {
            return people.OrderBy(p => p.Age).FirstOrDefault();
        }

        public static double AverageAge(this Person[] people)
        {
            if (people.Length == 0)
                return 0;

            return people.Select(p => p.Age).Average();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = {
            new Person("John", "Doe", 30),
            new Person("Jane", "Smith", 25),
            new Person("Alice", "Johnson", 35)
        };

            
            Person oldestPerson = people.FindOldest();
            Console.WriteLine($"The oldest person is: {oldestPerson.FirstName} {oldestPerson.LastName} ({oldestPerson.Age} years old)");

            
            Person youngestPerson = people.FindYoungest();
            Console.WriteLine($"The youngest person is: {youngestPerson.FirstName} {youngestPerson.LastName} ({youngestPerson.Age} years old)");

          
            double averageAge = people.AverageAge();
            Console.WriteLine($"Average age of people is: {averageAge}");
        }
    }
}
