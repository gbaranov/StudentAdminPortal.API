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
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
            //throw new NotImplementedException();
            //test VS git interface
        }

    }
}
