using System.Collections.Generic;
using ThreeTierArchitecture.DomainModel;

namespace ThreeTierArchitecture.DataLayer
{
    internal static class DataSource
    {
        public static List<Student> StudentList = new List<Student>()
        {
           new Student(){EmailId="User1",Password="Password",StudentName="vaishnavi",StudentId="A101",PhoneNumber=566757445},
           new Student(){EmailId="User2",Password="Password",StudentName="venkatesh",StudentId="A102",PhoneNumber=133536436},
           new Student(){EmailId="User3",Password="Password",StudentName="Balram",StudentId="A103",PhoneNumber=99436436},
           new Student(){EmailId="User4",Password="Password",StudentName="Harikumar",StudentId="A104",PhoneNumber=995436436},
           new Student(){EmailId="User5",Password="Password",StudentName="Harikumar",StudentId="A105",PhoneNumber=985436436},
           new Student(){EmailId="User6",Password="Password",StudentName="Shahanaz",StudentId="A106",PhoneNumber=795436436},
        };
    }
}
