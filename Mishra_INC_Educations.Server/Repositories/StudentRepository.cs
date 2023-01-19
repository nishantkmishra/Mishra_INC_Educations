using Dapper;
using Microsoft.Extensions.Configuration;
using Mishra_INC_Educations.Server.Abstractions;
using Mishra_INC_Educations.Server.DataAccess;
using Mishra_INC_Educations.Shared;
using Mishra_INC_Educations.Shared.Entities.Students;
using Mishra_INC_Educations.Shared.Entities.Users;
using Mishra_INC_Educations.Shared.Request.Students;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mishra_INC_Educations.Server.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IConfiguration configuration;

        public StudentRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<Response<int>> AddStudent(CreateStudentsCommand createStudentsCommand)
        {
            Response<int> response = new Response<int>();
            try
            {
                var result = new int();
                using (SqlConnection con = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
                {
                    con.Open();
                    Random random = new Random();
                    User user = new User();
                    user.Email = createStudentsCommand.FatherEmail;
                    user.MobileNo = createStudentsCommand.FatherMobileNo;
                    user.TemporaryPassword = random.ToString();
                    CreatePasswordHash(user.TemporaryPassword, out byte[] passwordHash, out byte[] passwordSalt);
                    user.PasswordHash = passwordHash;
                    user.PasswordSalt = passwordSalt;
                    user.IsActive = true;
                    user.CreatedBy = 1;
                    user.CreatedDate = DateTime.Now.Ticks;
                    using (var trans = con.BeginTransaction())
                    {
                        var createdUserId = await con.ExecuteScalarAsync<int>(SqlQueries.CreateUser, user, trans);
                        var student = new Student();
                        student.FirstName = createStudentsCommand.FirstName;
                        student.LastName = createStudentsCommand.LastName;
                        student.FatherName = createStudentsCommand.FatherName;
                        student.MotherName = createStudentsCommand.MotherName;
                        student.GuardianName = createStudentsCommand.GuardianName;
                        student.Address = createStudentsCommand.Address;
                        student.UserId = createdUserId;
                        student.CreatedDate = DateTime.Now.Ticks;
                        student.CreatedBy = 1;
                        student.IsActive = true;
                        student.ClassSections = createStudentsCommand.ClassSections;
                        student.ClassStandred = createStudentsCommand.ClassStandred;
                        student.ClassSections = createStudentsCommand.ClassSections;
                        student.PinCode = createStudentsCommand.PinCode;
                        result = await con.ExecuteAsync(SqlQueries.CreateStudent, student, trans);
                        trans.Commit();
                    }
                    if (result == 1)
                    {
                        response.Status = true;
                        response.ErrorMessage = string.Empty;
                        response.SuccessMessage = "Student Registered SuccessFully!";
                        response.Data = result;
                    }
                    else
                    {
                        response.Status = false;
                        response.ErrorMessage = "Something wen wrong please try again!";
                        response.SuccessMessage = string.Empty;
                        response.Data = result;
                    }
                    return response;
                }
            }
            catch (Exception ex)
            {
                // TO do logger
                response.Status = false;
                response.ErrorMessage = $"{ex.Message}";
                response.SuccessMessage = string.Empty;
                response.Data = new int();
            }
            return response;
        }

        public Task<Response<IReadOnlyList<Student>>> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
