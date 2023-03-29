using PresenceManagement.DataAccess.Models;

namespace PresenceManagement.DataAccess.Models
{
    public class DataBase
    {
        public  static List<Absence> Absence = new List<Absence>();
        public static List<Person> TPerson = new List<Person>();
        public static List<Teacher> TTeacher = new List<Teacher>();
        public static List<Users> TUser = new List<Users>();
        public static List<Students> TStudents = new List<Students>();
        public static List<Semestre> TSemestre = new List<Semestre>();
        public static List<SessionCourse> TSessionCourse = new List<SessionCourse>();
        public static List<Admin> TAdmin = new List<Admin>();
    }
}