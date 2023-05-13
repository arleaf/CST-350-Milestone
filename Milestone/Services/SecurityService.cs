using Milestone.Models;

namespace Milestone.Services
{
    public class SecurityService
    {
        SecurityDAO securityDAO = new SecurityDAO();

        public bool IsAdded(UserModel user)
        {
            return securityDAO.AddUser(user);
        }
    }
}
