using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZooApplication
{
    public partial class Maintenance : System.Web.UI.Page
    {
        string CONNECTION_STR = "server=cosc3380-02-team12.mysql.database.azure.com;" +
                                "uid=team12admin@cosc3380-02-team12;" +
                                "pwd=Team 12 is the very best team.;" +
                                "database=zoo";

        protected void Page_Load(object sender, EventArgs e)
        {
            // if is initial page load
            if (!IsPostBack)
            {
                // Create listSection by data binding
                listSection.DataSource = CreateDataSource(listSection);
                listSection.DataTextField = "SectionName";
                listSection.DataValueField = "SectionID";
                listSection.DataBind();

                // Create listFacility by data binding
                listFacility.DataSource = CreateDataSource(listFacility);
                listFacility.DataTextField = "FacilityName";
                listFacility.DataValueField = "FacilityID";
                listFacility.DataBind();

                // Create listOrderType by data binding
                listOrderType.DataSource = CreateDataSource(listOrderType);
                listOrderType.DataTextField = "OrderTypeName";
                listOrderType.DataValueField = "OrderTypeID";
                listOrderType.DataBind();

                // Create listMembership by data binding
                listMaintenance.DataSource = CreateDataSource(listMaintenance);
                listMaintenance.DataTextField = "EmployeeName";
                listMaintenance.DataValueField = "EmployeeID";
                listMaintenance.DataBind();

                // Display today's work orders
                BindQueryOutput();

                // Display out of order facilities
                ShowOOOFacilities();
            }
        }

        protected void Section_Changed(object sender, EventArgs e)
        {
            // Create listFacility by data binding
            listFacility.DataSource = CreateDataSource(listFacility);
            listFacility.DataTextField = "FacilityName";
            listFacility.DataValueField = "FacilityID";
            listFacility.DataBind();

            // Create listOrderType by data binding
            listOrderType.DataSource = CreateDataSource(listOrderType);
            listOrderType.DataTextField = "OrderTypeName";
            listOrderType.DataValueField = "OrderTypeID";
            listOrderType.DataBind();
        }

        protected void Facility_Changed(object sender, EventArgs e)
        {
            // Create listOrderType by data binding
            listOrderType.DataSource = CreateDataSource(listOrderType);
            listOrderType.DataTextField = "OrderTypeName";
            listOrderType.DataValueField = "OrderTypeID";
            listOrderType.DataBind();
        }

        protected void Date_Changed(object sender, EventArgs e)
        {
            BindQueryOutput();
        }

        protected void Report_Problem(object sender, EventArgs e)
        {
            // Get user input
            int orderType = Convert.ToInt32(listOrderType.SelectedValue);
            string year = inYear.Text.Trim();
            string month = inMonth.Text.Trim();
            string day = inDay.Text.Trim();
            string orderDate = year + "-" + month + "-" + day;
            int facilityID = Convert.ToInt32(listFacility.SelectedValue);
            string username = Request.QueryString["username"];
            int assignedTo = Convert.ToInt32(listMaintenance.SelectedValue);

            using (MySqlConnection conn = new MySqlConnection(CONNECTION_STR))
            {
                try
                {
                    // Connect to Azuer MySQL server
                    System.Diagnostics.Debug.WriteLine("Connecting to server...");
                    conn.Open();

                    // Generate new order ID
                    string query = "SELECT MAX(order_id) FROM work_order";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();
                    int orderID = 1;

                    if (result != DBNull.Value)
                    {
                        orderID += Convert.ToInt32(result);
                    }

                    // Get user_id from username
                    cmd.CommandText = "SELECT user_id FROM user_login WHERE username = @username";
                    cmd.Parameters.AddWithValue("@username", username);
                    int orderedBy = Convert.ToInt32(cmd.ExecuteScalar());

                    // Add new work order
                    cmd.CommandText = "INSERT INTO work_order VALUES " +
                                          "(@order_id, @order_type, @order_date, @facility, @ordered_by, @assigned_to);";
                    cmd.Parameters.AddWithValue("@order_id", orderID);
                    cmd.Parameters.AddWithValue("@order_type", orderType);
                    cmd.Parameters.AddWithValue("@order_date", orderDate);
                    cmd.Parameters.AddWithValue("@facility", facilityID);
                    cmd.Parameters.AddWithValue("@ordered_by", orderedBy);
                    cmd.Parameters.AddWithValue("@assigned_to", assignedTo);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }

            // Update today's work orders
            BindQueryOutput();

            // Update list of out of order facilities
            ShowOOOFacilities();
        }

        protected void Complete_Order(object sender, EventArgs e)
        {
            // Get user input
            int orderID = Convert.ToInt32(inOrderID.Text.Trim());

            using (MySqlConnection conn = new MySqlConnection(CONNECTION_STR))
            {
                try
                {
                    // Connect to Azure MySQL server
                    System.Diagnostics.Debug.WriteLine("Connecting to server...");
                    conn.Open();

                    // Delete work order
                    string query = "DELETE FROM work_order " +
                                   "WHERE order_id = @orderID;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@orderID", orderID);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }

            // Update today's work orders
            BindQueryOutput();

            // Update list of out of order facilities
            ShowOOOFacilities();
        }

        ICollection CreateDataSource(DropDownList list)
        {
            // Create/configure a DataTable to store data for the DropDownList
            DataTable table = new DataTable();

            string query = "";
            int sectionID = 0;
            int facilityID = 0;

            if (list.ID.Equals("listSection"))
            {
                table.Columns.Add(new DataColumn("SectionID", typeof(int)));
                table.Columns.Add(new DataColumn("SectionName", typeof(string)));

                query = "SELECT section_id, section_name FROM enum_section;";
            }

            if (list.ID.Equals("listFacility"))
            {
                sectionID = Convert.ToInt32(listSection.SelectedValue);

                table.Columns.Add(new DataColumn("FacilityID", typeof(int)));
                table.Columns.Add(new DataColumn("FacilityName", typeof(string)));

                query = "SELECT facility_id, facility_name FROM facility WHERE section = @section;";
            }

            if (list.ID.Equals("listOrderType"))
            {
                if (!listFacility.SelectedValue.Equals(""))
                {
                    facilityID = Convert.ToInt32(listFacility.SelectedValue);
                }

                table.Columns.Add(new DataColumn("OrderTypeID", typeof(int)));
                table.Columns.Add(new DataColumn("OrderTypeName", typeof(string)));

                query = "SELECT order_type_id, order_type_name " +
                        "FROM enum_work_order_type AS t, facility AS f " +
                        "WHERE t.facility_type = f.facility_type AND f.facility_id = @facilityID;";
            }

            if (list.ID.Equals("listMaintenance"))
            {
                table.Columns.Add(new DataColumn("EmployeeID", typeof(int)));
                table.Columns.Add(new DataColumn("EmployeeName", typeof(string)));

                query = "SELECT empl_id, first_name " +
                        "FROM employee AS e, enum_department AS d " +
                        "WHERE e.department = d.dept_id AND d.dept_name = 'maintenance';";
            }

            using (MySqlConnection conn = new MySqlConnection(CONNECTION_STR))
            {
                try
                {
                    // Connect to Azure MySQL server
                    System.Diagnostics.Debug.WriteLine("Connecting to server...");
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@section", sectionID);
                    cmd.Parameters.AddWithValue("@facilityID", facilityID);

                    // Execute command
                    System.Diagnostics.Debug.WriteLine("Executing command...");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Read query output
                        System.Diagnostics.Debug.WriteLine("Reading query output...");

                        while (reader.Read())
                        {
                            DataRow row = table.NewRow();
                            row[0] = reader[0];
                            row[1] = reader[1];
                            table.Rows.Add(row);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }

            // Return a new DataView based on the DataTable
            return new DataView(table);
        }

        void BindQueryOutput()
        {
            using (MySqlConnection conn = new MySqlConnection(CONNECTION_STR))
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");

                if (!(calendar.SelectedDate.Date == DateTime.MinValue.Date))
                {
                    date = calendar.SelectedDate.Date.ToString("yyyy-MM-dd");
                }
                string username = Request.QueryString["username"];

                try
                {
                    // Connect to Azure MySQL server
                    System.Diagnostics.Debug.WriteLine("Connecting to server...");
                    conn.Open();

                    // Get user_id from username
                    string query = "SELECT user_id FROM user_login WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    int userID = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.CommandText = "SELECT * FROM work_order WHERE order_date = @date AND assigned_to = @userID;";
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@userID", userID);

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    orderInfo.DataSource = table;
                    orderInfo.DataBind();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }
        }

        void ShowOOOFacilities()
        {
            using (MySqlConnection conn = new MySqlConnection(CONNECTION_STR))
            {
                try
                {
                    // Connect to Azure MySQL server
                    System.Diagnostics.Debug.WriteLine("Connecting to server...");
                    conn.Open();

                    string query = "SELECT * " +
                                   "FROM facility, enum_facility_status " +
                                   "WHERE facility_status = facility_status_id " +
                                   "AND facility_status_name = 'out of order';";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    oooFacilities.DataSource = table;
                    oooFacilities.DataBind();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }
        }
    }
}