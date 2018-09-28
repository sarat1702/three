using ThreeTierArchitecture.DomainModel;

using System.Linq;

namespace ThreeTierArchitecture.DataLayer
{
    internal class StudentRepo : IStudentRepo
    {
        public Student GetStudentDetails(string studentId)
        {
            return DataSource.StudentList.Where(m => m.StudentId == studentId).FirstOrDefault();
        }
    }
}