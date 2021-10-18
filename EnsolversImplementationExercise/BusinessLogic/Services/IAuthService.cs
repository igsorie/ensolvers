using BusinessLogic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public interface IAuthService
    {
        public string Login(AuthDTO authDTO);

        public bool IsLoggedIn(string token);
    }
}
