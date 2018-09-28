using System;
using ThreeTierArchitecture.BussinessLayer;
using ThreeTierArchitecture.DomainModel;

namespace ThreeTierArchitecture.ui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter EmailId");
            string emailId = Console.ReadLine();
            Console.WriteLine(" Enter Password");
            string password = Console.ReadLine();
            IAuthenticationBussiness authenticationobject = BussinessLayerFactory.GetAuthenticationRepo();
            string studentId = authenticationobject.ValidateLogin(emailId, password);
            Console.WriteLine(studentId);
            if(studentId != null)
            {
            IStudentBussiness studentObject = BussinessLayerFactory.GetStudentRepo();
            Student studentobj = studentObject.GetStudentDetails(studentId);
            PrintDetails(studentobj);
            }
            Console.ReadKey();
        }
        static void PrintDetails(Student studentobj)
        {
            Console.WriteLine(studentobj.StudentId);
            Console.WriteLine(studentobj.StudentName);
            Console.WriteLine(studentobj.PhoneNumber);            
        }
    }
}
