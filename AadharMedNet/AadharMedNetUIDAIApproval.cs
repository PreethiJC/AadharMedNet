using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

/// <summary>
/// Summary description for AadharMedNetUIDAIApproval
/// </summary>

namespace AadharMedNet
{
    public class AadharMedNetUIDAIApproval
    {
        public AadharMedNetUIDAIApproval()
        {
        }

        public static string[] getUIDAIMedCenters(string _path)
        {
            string[] allMedCenters = File.ReadAllLines(_path);
            return allMedCenters;
        }

        public static string[] getEligibilityCriterias(int _regAs, string _path)
        {
            string[] allUsersDetails = File.ReadAllLines(_path);
            string[] splittedDetails;

            foreach (string curUser in allUsersDetails)
            {
                splittedDetails = curUser.Split(';');
                if (splittedDetails[0] == _regAs.ToString())
                {
                    return splittedDetails[1].Split('|');
                }
            }

            return null;
        }
    }
}