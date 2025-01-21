using System;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Advisor compSciAdvisor = new()
            {
                Email = "testEmail@email.com",
                FullName = "John Doe",
                OfficeLocation = "A19 Rm 1234"
            };

            Student stu1 = new()
            {
                FirstName = "Jane",
                LastName = "Doe",
                DateOfBirth = new DateOnly(1999, 1, 15),
                AssignedAdvisor = compSciAdvisor,
                SchoolEmail = "testEmail@students.email.com",
                PhoneNumber = "555-555-5555",
            };
            Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName} as their assigned advisor");
        }
    }
}
