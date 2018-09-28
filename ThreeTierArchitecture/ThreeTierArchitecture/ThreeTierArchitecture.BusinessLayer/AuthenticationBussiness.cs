using ThreeTierArchitecture.DataLayer;
namespace ThreeTierArchitecture.BussinessLayer
{
    internal class AuthenticationBussiness:IAuthenticationBussiness
    {
        public string ValidateLogin(string email,string password)
        {
            return ThreeTierArchitecture.DataLayer.DataLayerFactory.GetAuthenticationRepo().ValidateLogin(email,password);
        }
    }
}
