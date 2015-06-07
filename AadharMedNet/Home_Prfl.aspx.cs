using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AadharMedNet
{
    public partial class Home_Prfl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            //AadharMedNetUserDetailsDB aadharMedNetUserDetailsDB = (AadharMedNetUserDetailsDB)Session["userDetails"];
            //string[] MedPrfl = AadharMedNetUserProfileHandler.getProfileHeader(aadharMedNetUserDetailsDB.UID, Server.MapPath(@"App_Data\AadharMedNetProfileHeader.txt"));
            //TblPICellDOBVal.Text = aadharMedNetUserDetailsDB.BirthDate.ToShortDateString();
            //if (aadharMedNetUserDetailsDB.Gender == 1)
            //{
            //    TblPICellGndrVal.Text = "Male";
            //}
            //else if (aadharMedNetUserDetailsDB.Gender == 2)
            //{
            //    TblPICellGndrVal.Text = "Female";
            //}
            //else if (aadharMedNetUserDetailsDB.Gender == 3)
            //{
            //    TblPICellGndrVal.Text = "Transgender";
            //}
            //TblPICellPhNoVal.Text = aadharMedNetUserDetailsDB.MobileNo.ToString();
            //TblPICellBldGrpVal.Text = MedPrfl[2];
            //TblPICellHghtVal.Text = MedPrfl[3];
            //TblPICellWghtVal.Text = MedPrfl[4] + " Kg.";
        }
    }
}