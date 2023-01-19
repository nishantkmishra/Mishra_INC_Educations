using System;
using System.Collections.Generic;
using System.Text;

namespace Mishra_INC_Educations.Server.DataAccess
{
    public static class SqlQueries
    {
        public static readonly string CreateUser = @"INSERT INTO [dbo].[Users]
                                               ([Email]
                                               ,[MobileNo]
                                               ,[PasswordHash]
                                               ,[PasswordSalt]
                                               ,[IsActive]
                                               ,[CreatedBy]
                                               ,[CreatedDate]
                                               ,[ModifiedBy]
                                               ,[ModifiedDate])
                                         OUTPUT INSERTED.Id
                                         VALUES
                                               (@Email
                                               ,@MobileNo
                                               ,@PasswordHash
                                               ,@PasswordSalt
                                               ,@IsActive
                                               ,@CreatedBy
                                               ,@CreatedDate
                                               ,@ModifiedBy
                                               ,@ModifiedDate)";


        public static readonly string CreateStudent = @"INSERT INTO [dbo].[Students]
                                                       ([FirstName]
                                                       ,[LastName]
                                                       ,[FatherName]
                                                       ,[MotherName]
                                                       ,[GuardianName]
                                                       ,[ClassStandred]
                                                       ,[ClassSections]
                                                       ,[Address]
                                                       ,[UserId]
                                                       ,[PinCode]
                                                       ,[IsActive]
                                                       ,[CreatedBy]
                                                       ,[CreatedDate]
                                                       ,[ModifiedBy]
                                                       ,[ModifiedDate])
                                                 VALUES
                                                       (@FirstName
                                                       ,@LastName
                                                       ,@FatherName
                                                       ,@MotherName
                                                       ,@GuardianName
                                                       ,@ClassStandred
                                                       ,@ClassSections
                                                       ,@Address
                                                       ,@UserId
                                                       ,@PinCode
                                                       ,@IsActive
                                                       ,@CreatedBy
                                                       ,@CreatedDate
                                                       ,@ModifiedBy
                                                       ,@ModifiedDate)";
    }
}
