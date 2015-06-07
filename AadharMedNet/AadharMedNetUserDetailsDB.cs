using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

/// <summary>
/// Summary description for AadharMedNetUserDetailsDB
/// </summary>

namespace AadharMedNet
{
    public class AadharMedNetUserDetailsDB:AadharMedNetBase
    {
        private string userDetailPath;
        private string userDetails;

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

        public string UserDetails
        {
            get
            {
                return userDetails;
            }
            set
            {
                userDetails = value;
            }
        }

        public AadharMedNetUserDetailsDB()
        {
        }

        public bool buildUserDetails(string _password)
        {
            string[] userDetails = File.ReadAllLines(userDetailPath);
            string[] userDetail;

            foreach (string user in userDetails)
            {
                userDetail = user.Split(';');
                if (userDetail[0] == this.UID && userDetail[1] == _password)
                {
                    this.userDetails = user;
                    this.UID = userDetail[0];
                    this.BirthDate = Convert.ToDateTime(userDetail[2]);
                    this.Gender = Convert.ToInt32(userDetail[3]);
                    this.MobileNo = Convert.ToInt64(userDetail[4]);
                    this.EmailId = userDetail[5];
                    return true;
                }
            }
            return false;
        }
    }
}