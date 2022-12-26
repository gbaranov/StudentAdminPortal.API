using StudentAdminPortal.API.DataModels;
using System.Collections.Generic;

namespace StudentAdminPortal.API.Repositories
{
    public interface iStudentRepository
    {
        List<Student> GetStudents();
    }
}
