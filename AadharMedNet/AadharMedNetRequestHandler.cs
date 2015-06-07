﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

/// <summary>
/// Summary description for AadharMedNetRequestHandler
/// </summary>

namespace AadharMedNet
{
    public class AadharMedNetRequestHandler:AadharMedNetBase
    {
        private string requestDetailPath;

        public string RequestDetailsPath
        {
            get
            {
                return requestDetailPath;
            }
            set
            {
                requestDetailPath = value;
            }
        }

        public AadharMedNetRequestHandler()
        {
        }

        public static string[][] inRequestsOrAppointments(string _uid, string _path)
        {
            string[] allUsersDetails = File.ReadAllLines(_path);
            string[] splittedDetails;
            string[][] inRequestDetails;
            int requestCount = 0;
            bool haveValue = false;

            inRequestDetails = new string[10][];

            foreach (string curUser in allUsersDetails)
            {
                splittedDetails = curUser.Split(';');
                if (splittedDetails[0] == _uid)
                {
                    haveValue = true;
                    inRequestDetails[requestCount] = splittedDetails[1].Split('|');
                    requestCount++;
                }
            }

            if (haveValue == false)
            {
                Array.Resize(ref inRequestDetails, 0);
            }
            else
            {
                Array.Resize(ref inRequestDetails, requestCount);
            }
            return inRequestDetails;
        }

        public static void createRequest(string _toUID, string _fromUID, string _reason, string _path, string _message = "NA")
        {
            using (StreamWriter w = File.AppendText(_path))
            {
                w.Write("\n" + _toUID + ";" + _fromUID + "|" + _reason + "|" + _message);
            }
        }

        public static void createAppointment(string _uid, string _reason, DateTime _date, DateTime _time, string _medCenter, string _path)
        {
            using (StreamWriter w = File.AppendText(_path))
            {
                w.Write("\n" + _uid + ";" + _reason + "|" + _date.ToString("dd-MM-yyyy") + "|" + _time.ToString("hh:mm:ss") + "|" + _medCenter);
            }
        }
    }
}