using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZooApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EmployeeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("pageEmployee.aspx");
        }

        protected void VisitorBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("pageVisitor.aspx");
        }

        protected void MemberBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("pageMember.aspx");
        }
    }
}