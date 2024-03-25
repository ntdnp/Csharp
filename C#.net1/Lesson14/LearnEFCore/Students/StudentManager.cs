using FirstDemo.Majors;
using FirstDemo.Studens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Students
{

    public class StudentManager
    {
        private readonly StudentService _studentService;
        public StudentManager()
        {
            _studentService = new StudentService();


        }
        public void ManagerStudent()
        {
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("Please choose the option");
                Console.WriteLine("1. Get all student");
                Console.WriteLine("2. Create student");
                Console.WriteLine("3. Update student");
                Console.WriteLine("4. Delete student");
                int.TryParse(Console.ReadLine(), out int option);
                switch (option)
                {
                    case 1:
                        var allStudents = _studentService.GetAllStudent();
                        Console.WriteLine("List of all majors:");
                        foreach (var student1 in allStudents)
                        {
                            Console.WriteLine($"- {student1.StudentName}");
                        }

                        break;

                    case 2:
                        Console.WriteLine("Input student name: ");
                        var studentName = Console.ReadLine();

                        Console.WriteLine("Input student age: ");
                        int age;
                        while (!int.TryParse(Console.ReadLine(), out age))
                        {
                            Console.WriteLine("Invalid age. Please enter a valid integer value for age.");
                        }

                        Console.WriteLine("Input student address: ");
                        var address = Console.ReadLine();

                        Console.WriteLine("Input student major ID: ");
                        Guid majorId;
                        while (!Guid.TryParse(Console.ReadLine(), out majorId))
                        {
                            Console.WriteLine("Invalid major ID. Please enter a valid GUID value for major ID.");
                        }

                        var student = new CreateStudentViewModel
                        {
                            StudentName = studentName,
                            Age = age,
                            Address = address,
                            MajorId = majorId
                        };

                        try
                        {
                            _studentService.CreateStudent(student);
                            Console.WriteLine($"Create student '{studentName}' successfully.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;
                    case 3:
                        Console.WriteLine("Input student ID to update: ");
                        var idToUpdate = Guid.Parse(Console.ReadLine());

                        Console.WriteLine("Input new student name: ");
                        var newName = Console.ReadLine();

                        Console.WriteLine("Input new age: ");
                        if (!int.TryParse(Console.ReadLine(), out int newAge))
                        {
                            Console.WriteLine("Invalid age input.");
                            break;
                        }

                        Console.WriteLine("Input new address: ");
                        var newAddress = Console.ReadLine();

                        Console.WriteLine("Input new major ID: ");
                        if (!Guid.TryParse(Console.ReadLine(), out Guid newMajorId))
                        {
                            Console.WriteLine("Invalid major ID input.");
                            break;
                        }

                        Console.WriteLine("Input new status (1 for Active, 0 for Inactive): ");
                        if (!int.TryParse(Console.ReadLine(), out int statusInput) || (statusInput != 0 && statusInput != 1))
                        {
                            Console.WriteLine("Invalid status input.");
                            break;
                        }
                        var newStatus = (EntityStatus)statusInput;

                        var model = new UpdateStudentViewModel
                        {
                            Id = idToUpdate,
                            StudentName = newName,
                            Age = newAge,
                            Address = newAddress,
                            MajorId = newMajorId,
                            Status = newStatus
                        };

                        _studentService.UpdateStudent(model);



                        break;
                    case 4:
                       
                        break;
                    default:
                        Console.WriteLine("please choose from 1=>4");
                        break;

                }
                Console.WriteLine("Do you want to continue adding more majors? (y/n)");
                var continueInput = Console.ReadLine().ToLower();
                if (continueInput != "y")
                {
                    isContinue = false;
                }

            }
        }
    }
}
