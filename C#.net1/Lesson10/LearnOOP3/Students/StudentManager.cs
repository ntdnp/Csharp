using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP3.Students
{
    public class StudentManager
    {
        public void RunApp()
        {
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("Choose the option:");
                Console.WriteLine("1- Add Student");
                Console.WriteLine("2- Show Students");
                Console.WriteLine("3- Search Student By No");
                Console.WriteLine("4- Get Max Score Student");
                Console.WriteLine("0- Exit");
                int.TryParse(Console.ReadLine(), out int option);

                switch (option)
                {
                    case 1:

                        Console.WriteLine("Input the student No");
                        bool checkNo = int.TryParse(Console.ReadLine(), out int no) && no > 0;
                        while (!checkNo)
                        {
                            Console.WriteLine("no must great than 0");
                            checkNo = int.TryParse(Console.ReadLine(), out no) && no > 0;
                        }

                        Console.WriteLine("Input the student Name");
                        string name = Console.ReadLine();

                        //Duẩn
                        Console.WriteLine("Input the student avgScore");
                        bool checkAvgScore = double.TryParse(Console.ReadLine(), out double avgScore) && avgScore >= 0 && avgScore <= 10;
                        while (!checkAvgScore)
                        {
                            Console.WriteLine("avgScore must be between 0 - 10");
                            checkAvgScore = double.TryParse(Console.ReadLine(), out avgScore) && avgScore >= 0 && avgScore <= 10;
                        }
                        //

                        var student = new Student(no, name, avgScore);
                        AddStudent(student);
                        break;
                    case 2:
                        ShowStudents();
                        break;

                    case 3:
                        Console.WriteLine("Input the student No");
                        int.TryParse(Console.ReadLine(), out int no1);
                        SearchStudent(no1);
                        break;
                    case 4:
                        GetMaxScoreStudent();
                        break;
                    case 0:
                        return;
                    default:
                        break;

                }

                Console.WriteLine("Do you want to continue y/n");
                string choose = Console.ReadLine();
                if (choose.Equals("y"))
                {
                    isContinue = true;
                }
                else
                {
                    isContinue = false;
                }

            }
        }



        private List<Student> listStudents;
        public StudentManager()
        {
            listStudents = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            listStudents.Add(student);
        }

        public void ShowStudents()
        {
            if (!listStudents.Any())
            {
                Console.WriteLine("not found");
            }
            foreach (var student in listStudents)
            {
                Console.WriteLine(BuildStudentInfo(student));
            }
        }

        public void SearchStudent(int no)
        {
            var student = listStudents.FirstOrDefault(s => s.No == no);
            if (student != null)
            {
                Console.WriteLine(BuildStudentInfo(student));
            }
            else
            {
                Console.WriteLine("not found");
            }
        }

        public void GetMaxScoreStudent()
        {
            var student = listStudents.OrderBy(s => s.AvgScore).LastOrDefault();
            if (student != null)
            {
                Console.WriteLine(BuildStudentInfo(student));
            }
            else
            {
                Console.WriteLine("not found");
            }
        }

        private string BuildStudentInfo(Student student)
        {
            return $"No: {student.No} - Name: {student.Name} - Average Score: {student.AvgScore}";
        }


    }

}
