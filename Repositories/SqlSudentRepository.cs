using StudentAdminPortal.API.DataModels

namespace StudentAdminPortal.API.Repositories
{
    public class SqlSudentRepository: iStudentRepository
    {
        private readonly StudentAdminContext context;
        public SqlSudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }
        public List<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

    }
}
