using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AadharMedNet
{
    public partial class Viewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LnkBtnReq_Click(object sender, EventArgs e)
        {
            PnlPrvt.Visible = false;
            PnlReq.Visible = true;
        }

        protected void BtnReq_Click(object sender, EventArgs e)
        {

        }
    }
}