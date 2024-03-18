using LearnEFCore.Entities;
using LearnEFCore.Majors;
using LearnEFCore.Studens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LearnEFCore.Students
{
    public interface IStudentService
    {
        void CreateStudent(CreateStudentViewModel model);
        void UpdateStudent(UpdateStudentViewModel model);
        List<StudentViewModel> GetAllStudent();
   

    }
    public class StudentService : IStudentService
    {
        private readonly StudentDbContext _context;
        public StudentService()
        {
            _context = new StudentDbContext();

        }
        public void CreateStudent(CreateStudentViewModel model)
        {
            var student = new Student
            {
                Id = Guid.NewGuid(),
                StudentName = model.StudentName,
                Age =model.Age,
                Address = model.Address,
                MajorId = model.MajorId,
                Status = EntityStatus.Active,
                CreatedDate = DateTime.Now,

            };
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public List<StudentViewModel> GetAllStudent()
        {
            var students = _context.Students;
            var studentViewModels = students.Select(s => new StudentViewModel
            {
                Id = s.Id,
                StudentName = s.StudentName,
                Age = s.Age,
                Address = s.Address,
                MajorId = s.MajorId,
                StatusStudent = s.Status.ToString()



            }).ToList();
            return studentViewModels;
        }

        public void UpdateStudent(UpdateStudentViewModel model)
        {
            try
            {
                var student = _context.Students.FirstOrDefault(s => s.Id == model.Id);
                if (student != null)
                {
                    
                    student.StudentName = model.StudentName;
                    student.Age = model.Age;
                    student.Address = model.Address;
                    student.MajorId = model.MajorId;
                    student.Status = model.Status;

                    _context.SaveChanges();
                    Console.WriteLine($"Student with ID {model.Id} updated successfully.");
                }
                else
                {
                    Console.WriteLine($"Student with ID {model.Id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating student: {ex.Message}");
            }

        }
    }
}
