using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;

/// <summary>
/// Summary description for AadharMedNetSearchBase
/// </summary>

namespace AadharMedNet
{
    public class AadharMedNetSearchBase
    {
        private string userDetailPath;

        public string UserDetailPath
        {
            get
            {
                return userDetailPath;
            }
            set
            {
                userDetailPath = value;
            }
        }

        public AadharMedNetSearchBase()
        {
        }

        private string[] getUsers(string _uid)
        {
            string[] allUsersDetails = File.ReadAllLines(userDetailPath);
            string[] splittedDetails;

            foreach (string curUser in allUsersDetails)
            {
                splittedDetails = curUser.Split(';');
                if (splittedDetails[0] == _uid)
                {
                    return splittedDetails;
                }
            }
            return null;
        }

        public string[][] searchByCategory(int _regAs, string _path)
        {
            string[] allUsersDetails = File.ReadAllLines(_path);
            string[] splittedDetails;
            string[][] userDetails;
            int userCount = 0;
            bool haveValue = false;

            userDetails = new string[10][];

            foreach (string curUser in allUsersDetails)
            {
                splittedDetails = curUser.Split(';');
                if (Convert.ToInt32(splittedDetails[3]) == _regAs && Convert.ToInt32(splittedDetails[4]) == 2)
                {
                    haveValue = true;
                    userDetails[userCount] = this.getUsers(splittedDetails[0]);
                    userCount++;
                }
            }
            if (haveValue == false)
            {
                Array.Resize(ref userDetails, 0);
            }
            else
            {
                Array.Resize(ref userDetails, userCount);
            }
            return userDetails;
        }
    }
}