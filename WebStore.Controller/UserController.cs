using WebStore.Model;
using WebStore.DataAccess;

namespace WebStore.Controller
{
    public class UserController
    {
        public int AuthenticateUser(User user)
        {
            return new UserAccess().AuthenticateUser(user);
        }
    }
}
