namespace ThreeTierArchitecture.BussinessLayer
{
    public interface IAuthenticationBussiness
    {
      string ValidateLogin(string email,string password);  
    } 
}
    