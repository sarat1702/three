namespace ThreeTierArchitecture.DataLayer
{
    public static class DataLayerFactory
    {
        public static IAuthenticationRepo GetAuthenticationRepo()
        {
            return new AuthenticationRepo();
        }

        public static IStudentRepo GetStudentRepo()
        {
            return new StudentRepo();
        }
    }
}