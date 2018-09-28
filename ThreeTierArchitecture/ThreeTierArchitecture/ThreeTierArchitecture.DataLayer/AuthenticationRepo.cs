using System.Linq;
using System;

namespace ThreeTierArchitecture.DataLayer
{
    internal class AuthenticationRepo:IAuthenticationRepo
    {
        public string ValidateLogin(string email,string password)
        {
            if(DataSource.StudentList.Any(p=>p.EmailId==email&&p.Password==password))
            {
            return DataSource.StudentList.Where(m => m.EmailId == email && m.Password == password).FirstOrDefault().StudentId; 
            }
            else{
                Console.WriteLine("enter valid email Password");
                return null;
            }
        }
    }
}