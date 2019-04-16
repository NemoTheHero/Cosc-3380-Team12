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
    public partial class Administrator : System.Web.UI.Page
    {
        String connectionString = "server=cosc3380-02-team12.mysql.database.azure.com;" +
                                    "uid=team12admin@cosc3380-02-team12;" +
                                    "pwd=Team 12 is the very best team.;" +
                                    "database=zoo";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClearTransactionForm();
                KeyLabel.Visible = false;
                KeyTextBox.Visible = false;
                SearchRecordBtn.Visible = false;
                ViewTableBtn.Visible = false;
            }
        }

        // DROPDOWN INDEX CHANGE EVENTS
        protected void TransactionDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearTransactionForm();
            int index = TransactionDropDown.SelectedIndex;
            switch (index)
            {
                case 0: // DEFAULT
                    break;
                case 1: // ANIMAL
                    TransLbl1.Text = "Animal ID";
                    TransLbl2.Text = "Name";
                    TransLbl3.Text = "Species";
                    TransLbl4.Text = "Health Profile";
                    TransLbl5.Text = "Diet";
                    TransLbl6.Text = "Exhibit";
                    ShowSix();
                    ShowButtons();
                    break;
                case 2: // CONTACT
                    TransLbl1.Text = "Phone Number";
                    TransLbl2.Text = "Email Address";
                    TransLbl3.Text = "Street Address";
                    TransLbl4.Text = "City";
                    TransLbl5.Text = "State";
                    TransLbl6.Text = "Zip Code";
                    ShowSix();
                    ShowButtons();
                    break;
                case 3: // DIET
                    TransLbl1.Text = "Diet ID";
                    TransLbl2.Text = "Diet Type";
                    TransLbl3.Text = "Feeding Size";
                    TransLbl4.Text = "Unit(s)";
                    TransLbl5.Text = "Feedings Per Day";
                    ShowFive();
                    ShowButtons();
                    break;
                case 4: // EMPLOYEE
                    TransLbl1.Text = "Employee ID";
                    TransLbl2.Text = "First Name";
                    TransLbl3.Text = "Last Name";
                    TransLbl4.Text = "Contact Info";
                    TransLbl5.Text = "Job Position";
                    TransLbl6.Text = "Department";
                    ShowSix();
                    ShowButtons();
                    break;
                case 5: // EXHIBIT
                    TransLbl1.Text = "Exhibit ID";
                    TransLbl2.Text = "Exhibit Name";
                    TransLbl3.Text = "Exhibit Size";
                    TransLbl4.Text = "Unit(s)";
                    TransLbl5.Text = "Ecosystem";
                    TransLbl6.Text = "Section";
                    ShowSix();
                    ShowButtons();
                    break;
                case 6: // FACILITY
                    TransLbl1.Text = "Facility ID";
                    TransLbl2.Text = "Facility Type";
                    TransLbl3.Text = "Status";
                    TransLbl4.Text = "Section";
                    TransLbl5.Text = "Facility Name";
                    ShowFive();
                    ShowButtons();
                    break;
                case 7: // HANDLER
                    TransLbl1.Text = "Animal ID";
                    TransLbl2.Text = "Employee ID";
                    ShowTwo();
                    ShowButtons();
                    break;
                case 8: // JOB POSITION
                    TransLbl1.Text = "Position ID";
                    TransLbl2.Text = "Job Title";
                    ShowTwo();
                    ShowButtons();
                    break;
                case 9: // MEMBERSHIP
                    TransLbl1.Text = "Member ID";
                    TransLbl2.Text = "Membership Type";
                    TransLbl3.Text = "First Name";
                    TransLbl4.Text = "Last Name";
                    TransLbl5.Text = "Phone Number";
                    TransLbl6.Text = "Registration Date";
                    TransTb6.Text = "YYYY-MM-DD";
                    TransLbl7.Text = "Membership Status";
                    ShowSeven();
                    ShowButtons();
                    break;
                case 10: // USER LOGIN
                    TransLbl1.Text = "User ID";
                    TransLbl2.Text = "Username";
                    TransLbl3.Text = "Password";
                    ShowThree();
                    ShowButtons();
                    break;
                case 11: // WORK ORDER
                    TransLbl1.Text = "Order Number";
                    TransLbl2.Text = "Type of Work";
                    TransLbl3.Text = "Order Date";
                    TransTb3.Text = "YYYY-MM-DD";
                    TransLbl4.Text = "Facility ID";
                    TransLbl5.Text = "Ordered by:";
                    TransLbl6.Text = "Assigned to:";
                    TransLbl7.Text = "Order Status";
                    ShowSeven();
                    ShowButtons();
                    break;
            }            
        }
        protected void QueryDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyLabel.Visible = true;
            KeyTextBox.Visible = true;
            SearchRecordBtn.Visible = true;
            ViewTableBtn.Visible = true;
        }

        // BUTTON ACTIONS & EVENTS
        protected void CreateBtn_Click(object sender, EventArgs e)
        {
            int index = TransactionDropDown.SelectedIndex;
            String query = "";
            String input1 = "";
            String input2 = TransTb2.Text.Trim();
            String input3 = TransTb3.Text.Trim();
            String input4 = TransTb4.Text.Trim();
            String input5 = TransTb5.Text.Trim();
            String input6 = TransTb6.Text.Trim();
            String input7 = TransTb7.Text.Trim();
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command;

            switch (index)
            {
                case 0: // DEFAULT
                    ShowFailureMessage();                    
                    break;
                case 1: // ANIMAL
                    input1 = GenerateRecordID(index);
                    query = "INSERT INTO animal VALUES (@one, @two, @three, @four, @five, @six);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    command.Parameters.AddWithValue("@six", input6);
                    AttemptTransaction(command);           
                    connection.Close();
                    break;
                case 2: // CONTACT
                    input1 = TransTb1.Text.Trim();
                    query = "INSERT INTO contact VALUES (@one, @two, @three, @four, @five, @six);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    command.Parameters.AddWithValue("@six", input6);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 3: // DIET
                    input1 = GenerateRecordID(index);
                    query = "INSERT INTO diet VALUES (@one, @two, @three, @four, @five);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 4: // EMPLOYEE
                    input1 = GenerateRecordID(index);
                    query = "INSERT INTO employee VALUES (@one, @two, @three, @four, @five, @six);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    command.Parameters.AddWithValue("@six", input6);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 5: // EXHIBIT
                    input1 = GenerateRecordID(index);
                    query = "INSERT INTO exhibit VALUES (@one, @two, @three, @four, @five, @six);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    command.Parameters.AddWithValue("@six", input6);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 6: // FACILITY
                    input1 = GenerateRecordID(index);
                    query = "INSERT INTO facility VALUES (@one, @two, @three, @four, @five);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 7: // HANDLER
                    TransLbl1.Text = "Error:";
                    TransTb1.Text = "Handlers can only be updated!";
                    TransTb2.Visible = false;
                    TransLbl2.Visible = false;
                    TransTb3.Visible = false;
                    TransLbl3.Visible = false;
                    TransTb4.Visible = false;
                    TransLbl4.Visible = false;
                    TransTb5.Visible = false;
                    TransLbl5.Visible = false;
                    TransTb6.Visible = false;
                    TransLbl6.Visible = false;
                    TransTb7.Visible = false;
                    TransLbl7.Visible = false;
                    break;
                case 8: // JOB POSITION
                    input1 = GenerateRecordID(index);
                    query = "INSERT INTO enum_job_position VALUES (@one, @two);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 9: // MEMBERSHIP
                    input1 = GenerateRecordID(index);
                    query = "INSERT INTO membership VALUES (@one, @two, @three, @four, @five, @six, @seven);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    command.Parameters.AddWithValue("@six", input6);
                    command.Parameters.AddWithValue("@seven", input7);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 10: // USER LOGIN
                    input1 = GenerateRecordID(index);
                    query = "INSERT INTO user_login VALUES (@one, @two, @three);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 11: // WORK ORDER
                    input1 = GenerateRecordID(index);
                    query = "INSERT INTO word_order VALUES (@one, @two, @three, @four, @five, @six, @seven);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    command.Parameters.AddWithValue("@six", input6);
                    command.Parameters.AddWithValue("@seven", input7);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
            }
        }
        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int index = TransactionDropDown.SelectedIndex;
            String query = "";
            String input1 = TransTb1.Text.Trim();
            String input2 = TransTb2.Text.Trim();
            String input3 = TransTb3.Text.Trim();
            String input4 = TransTb4.Text.Trim();
            String input5 = TransTb5.Text.Trim();
            String input6 = TransTb6.Text.Trim();
            String input7 = TransTb7.Text.Trim();
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command;

            switch (index)
            {
                case 0: // DEFAULT
                    ShowFailureMessage();
                    break;
                case 1: // ANIMAL
                    query = "UPDATE animal SET " +
                        "animal_name = @two" + ", " +
                        "species = @three" + ", " +
                        "health_profile = @four" + ", " +
                        "diet = @five" + ", " +
                        "exhibit = @six" + " WHERE " +
                        "animal_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    command.Parameters.AddWithValue("@six", input6);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 2: // CONTACT
                    query = "UPDATE contact SET " +
                        "email_addr = @two" + ", " +
                        "addr_line = @three" + ", " +
                        "city = @four" + ", " +
                        "state = @five" + ", " +
                        "zip_code = @six" + " WHERE " +
                        "phone_no = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    command.Parameters.AddWithValue("@six", input6);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 3: // DIET
                    query = "UPDATE diet SET " +
                        "diet_type = @two" + ", " +
                        "feeding_size = @three" + ", " +
                        "feeding_unit = @four" + ", " +
                        "feedings_per_day = @five" + " WHERE " +
                        "diet_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 4: // EMPLOYEE
                    query = "UPDATE employee SET " +
                        "first_name = @two" + ", " +
                        "last_name = @three" + ", " +
                        "contact_info = @four" + ", " +
                        "job_position = @five" + ", " +
                        "department = @six" + " WHERE " +
                        "empl_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    command.Parameters.AddWithValue("@six", input6);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 5: // EXHIBIT
                    query = "UPDATE exhibit SET " +
                        "exhibit_name = @two" + ", " +
                        "exhibit_size = @three" + ", " +
                        "exhibit_unit= @four" + ", " +
                        "ecosystem = @five" + ", " +
                        "section = @six" + " WHERE " +
                        "exhibit_id= @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    command.Parameters.AddWithValue("@six", input6);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 6: // FACILITY
                    query = "UPDATE facility SET " +
                        "facility_type = @two" + ", " +
                        "facility_status = @three" + ", " +
                        "section = @four" + ", " +
                        "facility_name = @five" + " WHERE " +
                        "facility_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 7: // HANDLER
                    query = "UPDATE animal_handler SET " +
                        "empl_id = @two" + " WHERE " +
                        "animal_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 8: // JOB POSITION
                    query = "UPDATE enum_job_position SET " +
                        "job_title = @two" + " WHERE " +
                        "position_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 9: // MEMBERSHIP
                    query = "UPDATE membership SET " +
                        "member_type = @two" + ", " +
                        "first_name = @three" + ", " +
                        "last_name = @four" + ", " +
                        "primary_contact = @five" + ", " +
                        "registration_date = @six" + ", " +
                        "member_status = @seven" + " WHERE " +
                        "member_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    command.Parameters.AddWithValue("@six", input6);
                    command.Parameters.AddWithValue("@seven", input7);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 10: // USER LOGIN
                    query = "UPDATE user_id SET " +
                        "username = @two" + ", " +
                        "user_password = @three" + " WHERE " +
                        "user_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 11: // WORK ORDER
                    query = "UPDATE work_order SET " +
                        "order_type = @two" + ", " +
                        "order_date = @three" + ", " +
                        "facility = @four" + ", " +
                        "ordered_by = @five" + ", " +
                        "assigned to = @six" + ", " +
                        "order_status = @seven" + " WHERE " +
                        "order_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    command.Parameters.AddWithValue("@six", input6);
                    command.Parameters.AddWithValue("@seven", input7);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
            }
        }
        protected void SearchRecordBtn_Click(object sender, EventArgs e)
        {
            // Get user input
            int keyID = Convert.ToInt32(KeyTextBox.Text.Trim());
            int index = QueryDropDown.SelectedIndex;
            String tableName = "default";
            String primaryKey = "default";
            if (index == 1)
            {
                tableName = "animal";
                primaryKey = "animal_id";
            }
            else if (index == 2)
            {
                tableName = "contact";
                primaryKey = "phone_no";
            }
            else if (index == 3)
            {
                tableName = "diet";
                primaryKey = "diet_id";
            }
            else if (index == 4)
            {
                tableName = "employee";
                primaryKey = "empl_id";
            }
            else if (index == 5)
            {
                tableName = "exhibit";
                primaryKey = "exhibit_id";
            }
            else if (index == 6)
            {
                tableName = "facility";
                primaryKey = "facility_id";
            }
            else if (index == 7)
            {
                tableName = "animal_handler";
                primaryKey = "animal_id";
            }
            else if (index == 8)
            {
                tableName = "enum_job_position";
                primaryKey = "position_id";
            }
            else if (index == 9)
            {
                tableName = "membership";
                primaryKey = "member_id";
            }
            else if (index == 10)
            {
                tableName = "user_login";
                primaryKey = "user_id";
            }
            else if (index == 11)
            {
                tableName = "work_order";
                primaryKey = "order_id";
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Connect to Azure MySQL server
                    System.Diagnostics.Debug.WriteLine("Connecting to server...");
                    connection.Open();

                    string query = "SELECT * FROM " + tableName + " WHERE " + primaryKey + " = @key_id;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@key_id", keyID);

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    SearchOutput.DataSource = table;
                    SearchOutput.DataBind();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }
        }        
        protected void ViewTableBtn_Click(object sender, EventArgs e)
        {
            int index = QueryDropDown.SelectedIndex;
            String tableName = "default";
            String primaryKey = "default";
            if (index == 1)
            {
                tableName = "animal";
            }
            else if (index == 2)
            {
                tableName = "contact";
            }
            else if (index == 3)
            {
                tableName = "diet";
            }
            else if (index == 4)
            {
                tableName = "employee";
            }
            else if (index == 5)
            {
                tableName = "exhibit";
            }
            else if (index == 6)
            {
                tableName = "facility";
            }
            else if (index == 7)
            {
                tableName = "animal_handler";
            }
            else if (index == 8)
            {
                tableName = "enum_job_position";
            }
            else if (index == 9)
            {
                tableName = "membership";
            }
            else if (index == 10)
            {
                tableName = "user_login";
            }
            else if (index == 11)
            {
                tableName = "work_order";
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Connect to Azure MySQL server
                    System.Diagnostics.Debug.WriteLine("Connecting to server...");
                    connection.Open();

                    string query = "SELECT * FROM @table;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@table", tableName);

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    SearchOutput.DataSource = table;
                    SearchOutput.DataBind();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }
        }

        // RECURSIVE METHODS
        protected String GenerateRecordID(int index)
        {
            String result;
            String query;
            switch (index)
            {
                case 0: // DEFAULT
                    result = "error";
                    return result;
                case 1: // ANIMAL
                    query = "SELECT MAX(animal_id) FROM animal;";
                    result = ExecuteIDReader(query);
                    return result;
                case 2: // CONTACT
                    result = "error";
                    return result;
                case 3: // DIET
                    query = "SELECT MAX(diet_id) FROM diet;";
                    result = ExecuteIDReader(query);
                    return result;
                case 4: // EMPLOYEE
                    query = "SELECT MAX(empl_id) FROM employee;";
                    result = ExecuteIDReader(query);
                    return result;
                case 5: // EXHIBIT
                    query = "SELECT MAX(exhibit_id) FROM exhibit;";
                    result = ExecuteIDReader(query);
                    return result;
                case 6: // FACILITY
                    query = "SELECT MAX(facility_id) FROM facility;";
                    result = ExecuteIDReader(query);
                    return result;
                case 7: // HANDLER
                    result = "error";
                    return result;
                case 8: // JOB POSITION
                    query = "SELECT MAX(position_id) FROM enum_job_position;";
                    result = ExecuteIDReader(query);
                    return result;
                case 9: // MEMBERSHIP
                    query = "SELECT MAX(member_id) FROM membership;";
                    result = ExecuteIDReader(query);
                    return result;
                case 10: // USER LOGIN
                    query = "SELECT MAX(user_id) FROM user_login;";
                    result = ExecuteIDReader(query);
                    return result;
                case 11: // WORK ORDER
                    query = "SELECT MAX(order_id) FROM work_order;";
                    result = ExecuteIDReader(query);
                    return result;
                default:
                    result = "error";
                    return result;
            }
        }
        protected String ExecuteIDReader(String query)
        {
            String result = "error";
            int response = 0;
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    response = reader.GetInt32(0) + 1;
                }
            }
            catch
            {
                response = 1;
            }
            reader.Close();
            connection.Close();
            result = response.ToString();
            return result;
        }
        protected void ClearTransactionForm()
        {
            // HIDE FORM LABELS
            TransLbl1.Visible = false;
            TransLbl2.Visible = false;
            TransLbl3.Visible = false;
            TransLbl4.Visible = false;
            TransLbl5.Visible = false;
            TransLbl6.Visible = false;
            TransLbl7.Visible = false;
            
            // RESET AND HIDE FORM TEXTBOXES
            TransTb1.Text = "";
            TransTb2.Text = "";
            TransTb3.Text = "";
            TransTb4.Text = "";
            TransTb5.Text = "";
            TransTb6.Text = "";
            TransTb7.Text = "";            
            TransTb1.Visible = false;
            TransTb2.Visible = false;
            TransTb3.Visible = false;
            TransTb4.Visible = false;
            TransTb5.Visible = false;
            TransTb6.Visible = false;
            TransTb7.Visible = false;

            // HIDE FORM BUTTONS
            CreateBtn.Visible = false;
            UpdateBtn.Visible = false;
        }
        protected void ShowTwo()
        {
            TransLbl1.Visible = true;
            TransLbl2.Visible = true;
            TransTb1.Visible = true;
            TransTb2.Visible = true;
        }
        protected void ShowThree()
        {
            TransLbl1.Visible = true;
            TransLbl2.Visible = true;
            TransLbl3.Visible = true;
            TransTb1.Visible = true;
            TransTb2.Visible = true;
            TransTb3.Visible = true;
        }
        protected void ShowFive()
        {
            TransLbl1.Visible = true;
            TransLbl2.Visible = true;
            TransLbl3.Visible = true;
            TransLbl4.Visible = true;
            TransLbl5.Visible = true;
            TransTb1.Visible = true;
            TransTb2.Visible = true;
            TransTb3.Visible = true;
            TransTb4.Visible = true;
            TransTb5.Visible = true;
        }
        protected void ShowSix()
        {
            TransLbl1.Visible = true;
            TransLbl2.Visible = true;
            TransLbl3.Visible = true;
            TransLbl4.Visible = true;
            TransLbl5.Visible = true;
            TransLbl6.Visible = true;
            TransTb1.Visible = true;
            TransTb2.Visible = true;
            TransTb3.Visible = true;
            TransTb4.Visible = true;
            TransTb5.Visible = true;
            TransTb6.Visible = true;
        }
        protected void ShowSeven()
        {
            TransTb1.Visible = true;
            TransTb2.Visible = true;
            TransTb3.Visible = true;
            TransTb4.Visible = true;
            TransTb5.Visible = true;
            TransTb6.Visible = true;
            TransTb7.Visible = true;
            TransLbl1.Visible = true;
            TransLbl2.Visible = true;
            TransLbl3.Visible = true;
            TransLbl4.Visible = true;
            TransLbl5.Visible = true;
            TransLbl6.Visible = true;
            TransLbl7.Visible = true;
        }
        protected void ShowButtons()
        {
            CreateBtn.Visible = true;
            UpdateBtn.Visible = true;
        }
        protected void ShowFailureMessage()
        {
            ClearTransactionForm();
            TransLbl1.Text = "Error:";
            TransLbl1.Visible = true;
            TransTb1.Text = "Transaction Failed!";
            TransTb1.Visible = true;
            TransLbl2.Text = "Check:";
            TransLbl2.Visible = true;
            TransTb2.Text = "Typos";
            TransTb2.Visible = true;
            TransLbl3.Text = "Check:";
            TransLbl3.Visible = true;
            TransTb3.Text = "Domain Constraints";
            TransTb3.Visible = true;
            TransLbl4.Text = "Check:";
            TransLbl4.Visible = true;
            TransTb4.Text = "Dependency Constraints";
            TransTb4.Visible = true;
        }
        protected void AttemptTransaction(MySqlCommand cmd)
        {
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                ShowFailureMessage();
            }
        }
    }
}