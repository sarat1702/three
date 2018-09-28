using ThreeTierArchitecture.DomainModel;
namespace ThreeTierArchitecture.DataLayer
{
    public interface IAuthenticationRepo
    {
      string ValidateLogin(string email,string password);  
    } 
}
    