using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AadharMedNet
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSbmt_Click(object sender, EventArgs e)
        {
            //AadharMedNetAuthClient aadharMedNetAuthClient = new AadharMedNetAuthClient();
            //aadharMedNetAuthClient.ApiPath = Server.MapPath(@"App_Data\AadharAPI\");
            //aadharMedNetAuthClient.buildSessionKey();
            //string xml = aadharMedNetAuthClient.buildAuthAndPost("999999990019", "Shivshankar Choudhury", "1968-05-13", "M");//, "1943-07-30", "F");
            //sring response = aadharMedNetAuthClient.authResponse(xml);
            //TxtBxNm.Text = response;

            
            //string UID = TxtBxUID.Text;
            //Response.Redirect("Home_NoPrfl.aspx");
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + UID + "')", true);
        }

        protected void BtnNxt_Click(object sender, EventArgs e)
        {
            PnlStp1.Visible = false;
            System.Web.UI.HtmlControls.HtmlGenericControl li = new System.Web.UI.HtmlControls.HtmlGenericControl();
            li = (System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("Step2");
            li.Attributes.Add("class", "active");
            PnlStp2.Visible = true;
        }

        protected void BtnPrev_Click(object sender, EventArgs e)
        {
            PnlStp2.Visible = false;
            System.Web.UI.HtmlControls.HtmlGenericControl li = new System.Web.UI.HtmlControls.HtmlGenericControl();
            li = (System.Web.UI.HtmlControls.HtmlGenericControl)this.FindControl("Step2");
            li.Attributes.Clear();
            PnlStp1.Visible = true;
        }
    }
}