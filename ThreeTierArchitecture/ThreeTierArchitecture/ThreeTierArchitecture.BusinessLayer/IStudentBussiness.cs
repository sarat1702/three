using ThreeTierArchitecture.DomainModel;

namespace ThreeTierArchitecture.BussinessLayer
{
    public interface IStudentBussiness
    {
        Student GetStudentDetails(string studentId);
    }
}