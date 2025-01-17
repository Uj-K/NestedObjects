using NestedObjects;
using System.Diagnostics;

Advisor compAdvisor = new()
{ 
    Email = "Anmarie@cptc.edu",
    FullName = "Anne Marie",
    OfficeLocation = "B17 Rm105"
        
};

Student stu1 = new()
{
    FirstName = "Homer",
    LastName = "Simpson",
    DateofBirth = new DateOnly(2020, 4, 20),
    AssignedAdvisor = compAdvisor,
    PhoneNumber = "253845653",
    SchoolEmail = "Simpson@cptc.edu"
};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName}" );