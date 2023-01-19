using Mishra_INC_Educations.Server.Repositories;
using Mishra_INC_Educations.Shared;
using Mishra_INC_Educations.Shared.Entities.Students;
using Mishra_INC_Educations.Shared.Entities.Users;
using Mishra_INC_Educations.Shared.Request.Students;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mishra_INC_Educations.Server.Abstractions
{
    public interface IStudentRepository
    {
        Task<Response<int>> AddStudent(CreateStudentsCommand createStudentsCommand);
        Task<Response<IReadOnlyList<Student>>> GetAllStudent();
    }
}
