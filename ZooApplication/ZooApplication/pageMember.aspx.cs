using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZooApplication
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DialogLbl.Visible = false;
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            String user = MemberBox.Text.Trim();
            String pwd = PasswordBox.Text.Trim();

            String connectionString = "server=cosc3380-02-team12.mysql.database.azure.com;" +
                                        "uid=team12admin@cosc3380-02-team12;" +
                                        "pwd=Team 12 is the very best team.;" +
                                        "database=zoo";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Connect to Azure MySQL server
                    System.Diagnostics.Debug.WriteLine("Connecting to server...");
                    conn.Open();

                    String query = ""; //TODO

                    // Configure login command
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", user);
                    cmd.Parameters.AddWithValue("@password", pwd);

                    // Execute command
                    System.Diagnostics.Debug.WriteLine("Authenticating user");
                    object result = cmd.ExecuteScalar();

                    // If user credentials exist in database
                    if (result != null)
                    {

                    }
                }
                catch
                {

                }
            }
        }
    }
}