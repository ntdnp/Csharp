using FirstDemo.Studens;

namespace FirstDemo.Students
{
    public interface IStudentService
    {
        Task CreateStudent(CreateStudentViewModel model);
        Task<PageResult<StudentViewModel>> GetStudents(SearchQuery query);
    }
}

