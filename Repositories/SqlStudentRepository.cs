using StudentAdminPortal.API.DataModels;
using Microsoft.EntityFrameworkCore;
namespace StudentAdminPortal.API.Repositories
{
    public class SqlStudentRepository: iStudentRepository
    {
        private readonly StudentAdminContext context;
        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }
        public List<Student> GetStudents()
        {
            return context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToList();
            //throw new NotImplementedException();
        }

    }
}
