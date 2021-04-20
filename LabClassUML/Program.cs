using System;

namespace LabClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Class UML!");

            Console.WriteLine();

            Person person = new Person("Alice", "12345 Wonderland Lane");
            string personResult = person.ToString();
            Console.WriteLine(personResult);

            Console.WriteLine();

            Student student = new Student("Ryan", "54321 Wrightway Lane", "Art & Science", 2022, 100);
            string studentResult = student.ToString();
            Console.WriteLine(studentResult);

            Console.WriteLine();

            Staff staff = new Staff("Reid Greene", "98765 Photo Lane", "Creative Studies", 250);
            string staffResult = staff.ToString();
            Console.WriteLine(staffResult);
        }
    }
}
