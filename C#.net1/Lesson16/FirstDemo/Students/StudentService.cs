using FirstDemo.Entities;
using FirstDemo.RepositoriesUOW;
using FirstDemo.Studens;
using Microsoft.EntityFrameworkCore;

namespace FirstDemo.Students
{
    public class StudentService : IStudentService
    {
        private readonly IGenericRepository<Student, Guid> _studentRepository;
        private readonly IGenericRepository<Major, Guid> _majorRepository;
        public StudentService(
            IGenericRepository<Student, Guid> studentRepository,
            IGenericRepository<Major, Guid> majorRepository)
        {
            _studentRepository = studentRepository;
            _majorRepository = majorRepository;

        }

        public Task CreateStudent(CreateStudentViewModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<PageResult<StudentViewModel>> GetStudents(SearchQuery query)
        {
            var pageResult = new PageResult<StudentViewModel>()
            {
                CurrentPage = query.PageIndex,
                PageSize = query.PageSize

            };
            var majors = _majorRepository.FindAll();
            var students = _studentRepository.FindAll();

            var result = from s in students
                         join m in majors on s.MajorId equals m.Id
                         select new StudentViewModel
                         {
                             StudentName = s.StudentName,
                             Id = s.Id,
                             MajorId = s.MajorId,
                             MajorName = m.MajorName,
                             Age = s.Age,
                             Address = s.Address
                         };
            if (!string.IsNullOrEmpty(query.Keyword))
            {
                result = result.Where(s => s.StudentName.Contains(query.Keyword));
            }
            pageResult.TotalCount = await result.CountAsync();

            pageResult.Data = await result.OrderBy(s => s.StudentName).Skip(query.SkipNo).Take(query.TakeNo).ToListAsync();
            return pageResult;
        }
    }
}
