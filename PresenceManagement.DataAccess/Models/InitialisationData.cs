
using Microsoft.EntityFrameworkCore.Storage;

namespace PresenceManagement.DataAccess.Models
{
public class InitialisationData
    {
        public static void Begin(){
        
            DataBase.TPerson.Add(new Person {
                    idPerson = 1,
                    lastNamePerson = "MBALI",
                    firstNamePerson = "Aube",
                    genrePerson = "Masculin",
            });
            DataBase.TPerson.Add(new Person {
                    idPerson = 2,
                    lastNamePerson = "MBALI",
                    firstNamePerson = "Aube",
                    genrePerson = "Masculin",
            });
            DataBase.TPerson.Add(new Person {
                    idPerson = 3,
                    lastNamePerson = "MBALI",
                    firstNamePerson = "Aube",
                    genrePerson = "Masculin",
            });

            DataBase.TTeacher.Add(new Teacher {
                IdTeacher = 1,
                TeacherName = "Assurance vie",
            });
            DataBase.TUser.Add(new Users {
                IdUsers = 2,
                EmailUser = "Assurance décès",
                PasswordUser = "",
            });
            DataBase.TStudents.Add(new Students {
                IdStudent = 3,
                NameStudent = "Assurance mixte (vie et décès)",
                FirstName = "",
            });
        
            DataBase.TSessionCourse.Add(new SessionCourse{
                IdSession = 1,
                NumberSession = 1,
            });
            DataBase.TAdmin.Add(new Admin{
                IdAdmin = 1,
                NameAdmin = "",
                FirstName = "",
            });
            
        }
    }
}