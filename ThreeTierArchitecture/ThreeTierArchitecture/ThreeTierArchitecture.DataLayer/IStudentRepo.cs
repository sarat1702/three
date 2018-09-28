using ThreeTierArchitecture.DomainModel;

namespace ThreeTierArchitecture.DataLayer
{
    public interface IStudentRepo
    {
        Student GetStudentDetails(string studentId);
    }
}