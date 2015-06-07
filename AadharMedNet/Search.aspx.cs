using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AadharMedNet
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSrch_Click(object sender, EventArgs e)
        {
            PnlSrchFltr.Visible = false;
            PnlSrchRslts.Visible = true;
        }

        protected void LnkBtn_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.open('Viewer.aspx','_blank');</script>");
        }
    }
}