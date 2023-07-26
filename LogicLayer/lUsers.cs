using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAdmin.LogicLayer
{
    public class lUsers
    {
        #region Class Properties
        private int userId;
        private string userName;
        private string password;
        private byte[] icon;
        private string status;
        #endregion

        #region Getter and Setters
        public int UserId
        {
            get { return UserId; }
            set { UserId = value; }
        }

        public string UserName
        {
            get { return UserName; }
            set { UserName = value; }
        }

        public string Password
        {
            get { return Password; }
            set { Password = value; }
        }

        public byte[] Icon
        {
            get { return Icon; }
            set { Icon = value; }
        }

        public string Status
        {
            get { return Status; }
            set { Status = value; }
        }
        #endregion

        #region Constructors
        public lUsers() { }

        public lUsers(int userid, string username, string password, byte[] icon, string status)
        {
            UserId = userid;
            UserName = username;
            Password = password;
            Icon = icon;
            Status = status;
        }
        #endregion
    }
}
