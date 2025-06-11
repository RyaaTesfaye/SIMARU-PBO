using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RUSUNAWAAA.Models;

namespace RUSUNAWAAA.Utils
{
    public static class SesiLogin
    {
        public static User LoggedInUser { get; private set; }
        public static void SetLoggedInUser(User user)
        {
            LoggedInUser = user;
        }
        public static void ClearSession()
        {
            LoggedInUser = null;
        }
        public static bool IsLoggedIn()
        {
            return LoggedInUser != null;
        }
    }

}
