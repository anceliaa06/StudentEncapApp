namespace StudentEncapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student
            {
                RollNo = 101,
                Name = "John Doe",
                Cgpa = 8.5
            };

            Student student2 = new Student
            {
                RollNo = 102,
                Name = "Jane Smith",
                Cgpa = 9.2
            };

            Console.WriteLine("STUDENT DETAILS");
            Console.WriteLine(student1);
            Console.WriteLine(student2);
        }
    }
}
