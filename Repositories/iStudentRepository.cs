using StudentAdminPortal.API.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    public interface iStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
    }
}
