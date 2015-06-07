using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;

/// <summary>
/// Summary description for AadharMedNetBase
/// </summary>

namespace AadharMedNet
{
    public class AadharMedNetBase
    {
        private string uid = "";
        private string emailId = "";
        private DateTime birthDate;
        private Int64 MobNo;
        private int regAs, gender;

        public AadharMedNetBase()
        {
        }

        public string UID
        {
            get
            {
                return uid;
            }
            set
            {
                uid = value;
            }
        }

        public int RegAs
        {
            get
            {
                return regAs;
            }
            set
            {
                regAs = value;
            }
        }

        public int Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public Int64 MobileNo
        {
            get
            {
                return MobNo;
            }
            set
            {
                MobNo = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }

        public string EmailId
        {
            get
            {
                return emailId;
            }
            set
            {
                emailId = value;
            }
        }

        public void createUser(string _password, string _path)
        {
            using (StreamWriter w = File.AppendText(_path))
            {
                w.Write("\n" + this.UID + ";" + _password + ";" + this.BirthDate.ToString("dd-MM-yyyy") + ";" + this.Gender.ToString() + ";" + this.MobileNo.ToString() + ";" + this.EmailId);
            }
        }
    }

}