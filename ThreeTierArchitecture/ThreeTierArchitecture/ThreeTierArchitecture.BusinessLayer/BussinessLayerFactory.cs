using ThreeTierArchitecture.DataLayer;

namespace ThreeTierArchitecture.BussinessLayer
{
    public static class BussinessLayerFactory
    {
         public static IAuthenticationBussiness GetAuthenticationRepo()
        {
            return new AuthenticationBussiness();
        }

        public static IStudentBussiness GetStudentRepo()
        {
            return new StudentBussiness();
        }
    }
}