using ThreeTierArchitecture.DomainModel;

namespace ThreeTierArchitecture.BussinessLayer
{
    internal class StudentBussiness : IStudentBussiness
    {
        public Student GetStudentDetails(string studentId)
        {
            return ThreeTierArchitecture.DataLayer.DataLayerFactory.GetStudentRepo().GetStudentDetails(studentId);
        }
    }
}