namespace Cambrain_Foodos.Data
{
    public class UserService
    {
        private static List<User> mockdb = new List<User>()
        {
            new User(){Name="Vijay", Email="vijay@gmail.com", PhoneNumber="6475545101", Address="30 tuxdeo", UserName="vj116", Password="4132"}
        };

        public async Task<bool> AddUser(User newUser)
        {
            mockdb.Add(newUser);
            return true;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return mockdb;
        }

    }
}
