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
    public partial class Admin : System.Web.UI.Page
    {
        String ConnString = "server=cosc3380-02-team12.mysql.database.azure.com;" +
                                    "uid=team12admin@cosc3380-02-team12;" +
                                    "pwd=Team 12 is the very best team.;" +
                                    "database=zoo;" + "convert zero datetime=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnString))
            {
                MySqlCommand DynamicList;

                // enum_department
                DynamicList = new MySqlCommand("Select dept_id, dept_name FROM enum_department", connection);
                connection.Open();
                DeptDrop10.DataSource = DynamicList.ExecuteReader();
                DeptDrop10.DataTextField = "dept_name";
                DeptDrop10.DataValueField = "dept_id";
                DeptDrop10.DataBind();
                connection.Close();

                DynamicList = new MySqlCommand("Select dept_id, dept_name FROM enum_department", connection);
                connection.Open();
                DeptDrop11.DataSource = DynamicList.ExecuteReader();
                DeptDrop11.DataTextField = "dept_name";
                DeptDrop11.DataValueField = "dept_id";
                DeptDrop11.DataBind();
                connection.Close();

                // enum_diet_type
                DynamicList = new MySqlCommand("Select diet_type_id, diet_type_name FROM enum_diet_type", connection);
                connection.Open();
                DietTypeDrop1.DataSource = DynamicList.ExecuteReader();
                DietTypeDrop1.DataTextField = "diet_type_name";
                DietTypeDrop1.DataValueField = "diet_type_id";
                DietTypeDrop1.DataBind();
                connection.Close();

                DynamicList = new MySqlCommand("Select diet_type_id, diet_type_name FROM enum_diet_type", connection);
                connection.Open();
                DietTypeDrop3.DataSource = DynamicList.ExecuteReader();
                DietTypeDrop3.DataTextField = "diet_type_name";
                DietTypeDrop3.DataValueField = "diet_type_id";
                DietTypeDrop3.DataBind();
                connection.Close();

                // enum_ecosystem
                DynamicList = new MySqlCommand("Select ecosystem_id, ecosystem_name FROM enum_ecosystem", connection);
                connection.Open();
                EcoDrop4.DataSource = DynamicList.ExecuteReader();
                EcoDrop4.DataTextField = "ecosystem_name";
                EcoDrop4.DataValueField = "ecosystem_id";
                EcoDrop4.DataBind();
                connection.Close();

                DynamicList = new MySqlCommand("Select ecosystem_id, ecosystem_name FROM enum_ecosystem", connection);
                connection.Open();
                EcoDrop19.DataSource = DynamicList.ExecuteReader();
                EcoDrop19.DataTextField = "ecosystem_name";
                EcoDrop19.DataValueField = "ecosystem_id";
                EcoDrop19.DataBind();
                connection.Close();

                // enum_facility_status
                DynamicList = new MySqlCommand("Select facility_status_id, facility_status_name FROM enum_facility_status", connection);
                connection.Open();
                FactStatDrop2.DataSource = DynamicList.ExecuteReader();
                FactStatDrop2.DataTextField = "facility_status_name";
                FactStatDrop2.DataValueField = "facility_status_id";
                FactStatDrop2.DataBind();
                connection.Close();

                // enum_facility_type
                DynamicList = new MySqlCommand("Select facility_type_id, facility_type_name FROM enum_facility_type", connection);
                connection.Open();
                FactTypeDrop1.DataSource = DynamicList.ExecuteReader();
                FactTypeDrop1.DataTextField = "facility_type_name";
                FactTypeDrop1.DataValueField = "facility_type_id";
                FactTypeDrop1.DataBind();
                connection.Close();

                DynamicList = new MySqlCommand("Select facility_type_id, facility_type_name FROM enum_facility_type", connection);
                connection.Open();
                FactTypeDrop2.DataSource = DynamicList.ExecuteReader();
                FactTypeDrop2.DataTextField = "facility_type_name";
                FactTypeDrop2.DataValueField = "facility_type_id";
                FactTypeDrop2.DataBind();
                connection.Close();

                // enum_health_condition
                DynamicList = new MySqlCommand("Select condition_id, condition_name FROM enum_health_condition", connection);
                connection.Open();
                HealthCondDrop7.DataSource = DynamicList.ExecuteReader();
                HealthCondDrop7.DataTextField = "condition_name";
                HealthCondDrop7.DataValueField = "condition_id";
                HealthCondDrop7.DataBind();
                connection.Close();

                DynamicList = new MySqlCommand("Select condition_id, condition_name FROM enum_health_condition", connection);
                connection.Open();
                HealthCondDrop8.DataSource = DynamicList.ExecuteReader();
                HealthCondDrop8.DataTextField = "condition_name";
                HealthCondDrop8.DataValueField = "condition_id";
                HealthCondDrop8.DataBind();
                connection.Close();

                DynamicList = new MySqlCommand("Select condition_id, condition_name FROM enum_health_condition", connection);
                connection.Open();
                HealthCondDrop9.DataSource = DynamicList.ExecuteReader();
                HealthCondDrop9.DataTextField = "condition_name";
                HealthCondDrop9.DataValueField = "condition_id";
                HealthCondDrop9.DataBind();
                connection.Close();

                DynamicList = new MySqlCommand("Select condition_id, condition_name FROM enum_health_condition", connection);
                connection.Open();
                HealthCondDrop12.DataSource = DynamicList.ExecuteReader();
                HealthCondDrop12.DataTextField = "condition_name";
                HealthCondDrop12.DataValueField = "condition_id";
                HealthCondDrop12.DataBind();
                connection.Close();

                DynamicList = new MySqlCommand("Select condition_id, condition_name FROM enum_health_condition", connection);
                connection.Open();
                HealthCondDrop13.DataSource = DynamicList.ExecuteReader();
                HealthCondDrop13.DataTextField = "condition_name";
                HealthCondDrop13.DataValueField = "condition_id";
                HealthCondDrop13.DataBind();
                connection.Close();

                // enum_job_position
                DynamicList = new MySqlCommand("Select position_id, job_title FROM enum_job_position", connection);
                connection.Open();
                JobPosDrop9.DataSource = DynamicList.ExecuteReader();
                JobPosDrop9.DataTextField = "job_title";
                JobPosDrop9.DataValueField = "position_id";
                JobPosDrop9.DataBind();
                connection.Close();

                DynamicList = new MySqlCommand("Select position_id, job_title FROM enum_job_position", connection);
                connection.Open();
                JobPosDrop10.DataSource = DynamicList.ExecuteReader();
                JobPosDrop10.DataTextField = "job_title";
                JobPosDrop10.DataValueField = "position_id";
                JobPosDrop10.DataBind();
                connection.Close();

                // enum_medication
                DynamicList = new MySqlCommand("Select med_id, med_name FROM enum_medication", connection);
                connection.Open();
                MedDrop10.DataSource = DynamicList.ExecuteReader();
                MedDrop10.DataTextField = "med_name";
                MedDrop10.DataValueField = "med_id";
                MedDrop10.DataBind();
                connection.Close();

                // enum_membership_status
                DynamicList = new MySqlCommand("Select member_status_id, member_status_name FROM enum_membership_status", connection);
                connection.Open();
                MemStatDrop11.DataSource = DynamicList.ExecuteReader();
                MemStatDrop11.DataTextField = "member_status_name";
                MemStatDrop11.DataValueField = "member_status_id";
                MemStatDrop11.DataBind();
                connection.Close();

                // enum_membership_type
                DynamicList = new MySqlCommand("Select member_type_id, member_type_name FROM enum_membership_type", connection);
                connection.Open();
                MemTypeDrop1.DataSource = DynamicList.ExecuteReader();
                MemTypeDrop1.DataTextField = "member_type_name";
                MemTypeDrop1.DataValueField = "member_type_id";
                MemTypeDrop1.DataBind();
                connection.Close();

                // enum_section
                DynamicList = new MySqlCommand("Select section_id, section_name FROM enum_section", connection);
                connection.Open();
                SectDrop3.DataSource = DynamicList.ExecuteReader();
                SectDrop3.DataTextField = "section_name";
                SectDrop3.DataValueField = "section_id";
                SectDrop3.DataBind();
                connection.Close();

                DynamicList = new MySqlCommand("Select section_id, section_name FROM enum_section", connection);
                connection.Open();
                SectDrop5.DataSource = DynamicList.ExecuteReader();
                SectDrop5.DataTextField = "section_name";
                SectDrop5.DataValueField = "section_id";
                SectDrop5.DataBind();
                connection.Close();

                DynamicList = new MySqlCommand("Select section_id, section_name FROM enum_section", connection);
                connection.Open();
                SectDrop20.DataSource = DynamicList.ExecuteReader();
                SectDrop20.DataTextField = "section_name";
                SectDrop20.DataValueField = "section_id";
                SectDrop20.DataBind();
                connection.Close();

                // enum_species
                DynamicList = new MySqlCommand("Select species_id, species_name FROM enum_species", connection);
                connection.Open();
                SpecDrop2.DataSource = DynamicList.ExecuteReader();
                SpecDrop2.DataTextField = "species_name";
                SpecDrop2.DataValueField = "species_id";
                SpecDrop2.DataBind();
                connection.Close();

                // enum_state - NOT POPULATED DYNAMICALLY

                // enum_unit_measure - NOT POPULATED DYNAMICALLY

                // enum_work_order_type
                DynamicList = new MySqlCommand("Select order_type_id, order_type_name FROM enum_work_order_type", connection);
                connection.Open();
                OrderDrop1.DataSource = DynamicList.ExecuteReader();
                OrderDrop1.DataTextField = "order_type_name";
                OrderDrop1.DataValueField = "order_type_id";
                OrderDrop1.DataBind();
                connection.Close();

                // employee
                DynamicList = new MySqlCommand("Select empl_id FROM employee", connection);
                connection.Open();
                EmployeeDrop.DataSource = DynamicList.ExecuteReader();
                EmployeeDrop.DataTextField = "empl_id";
                EmployeeDrop.DataValueField = "empl_id";
                EmployeeDrop.DataBind();
                connection.Close();

                DynamicList = new MySqlCommand("Select empl_id FROM employee", connection);
                connection.Open();
                EmployeeDrop4.DataSource = DynamicList.ExecuteReader();
                EmployeeDrop4.DataTextField = "empl_id";
                EmployeeDrop4.DataValueField = "empl_id";
                EmployeeDrop4.DataBind();
                connection.Close();

                DynamicList = new MySqlCommand("Select empl_id FROM employee", connection);
                connection.Open();
                EmployeeDrop5.DataSource = DynamicList.ExecuteReader();
                EmployeeDrop5.DataTextField = "empl_id";
                EmployeeDrop5.DataValueField = "empl_id";
                EmployeeDrop5.DataBind();
                connection.Close();

                //exhibit
                DynamicList = new MySqlCommand("Select exhibit_id, exhibit_name FROM exhibit", connection);
                connection.Open();
                ExhibDrop4.DataSource = DynamicList.ExecuteReader();
                ExhibDrop4.DataTextField = "exhibit_name";
                ExhibDrop4.DataValueField = "exhibit_id";
                ExhibDrop4.DataBind();
                connection.Close();

                // facility
                DynamicList = new MySqlCommand("Select facility_id, facility_name FROM facility", connection);
                connection.Open();
                FacilityDrop.DataSource = DynamicList.ExecuteReader();
                FacilityDrop.DataTextField = "facility_name";
                FacilityDrop.DataValueField = "facility_id";
                FacilityDrop.DataBind();
                connection.Close();
            }
            if (!IsPostBack)
            {
                ClearInsertForm();
                ClearUpdateForm();
                KeyLabel.Visible = false;
                KeyTextBox.Visible = false;
                SearchRecordBtn.Visible = false;
                ViewTableBtn.Visible = false;
                InsertDialog.Visible = false;
            }
        }

        // DROPDOWN INDEX CHANGE EVENTS
        protected void InsertDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearInsertForm();
            CreateBtn.Visible = true;
            int index = InsertDropDown.SelectedIndex;
            switch (index)
            {
                case 0: // DEFAULT - NULL
                    break;
                case 1: // ANIMAL -----------------------------------------------------

                    InsertLbl1.Text = "Name";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    InsertLbl2.Text = "Species";
                    InsertLbl2.Visible = true;
                    SpecDrop2.Visible = true;
                    InsertLbl3.Text = "Diet ID";
                    InsertLbl3.Visible = true;
                    DietTypeDrop3.Visible = true;
                    InsertLbl4.Text = "Exhibit ID";
                    InsertLbl4.Visible = true;
                    ExhibDrop4.Visible = true;
                    InsertLbl5.Text = "Date";
                    InsertLbl5.Visible = true;
                    InsertBox5.Text = "YYYY-MM-DD";
                    InsertBox5.Visible = true;
                    InsertLbl6.Text = "Sex";
                    InsertLbl6.Visible = true;
                    InsertBox6.Visible = true;
                    InsertLbl7.Text = "Date of Birth";
                    InsertLbl7.Visible = true;
                    InsertBox7.Text = "YYYY-MM-DD";
                    InsertBox7.Visible = true;
                    InsertLbl8.Text = "Weight";
                    InsertLbl8.Visible = true;
                    InsertBox8.Visible = true;
                    InsertLbl9.Text = "Unit(s)";
                    InsertLbl9.Visible = true;
                    UnitDrop9.Visible = true;
                    InsertLbl10.Text = "Height";
                    InsertLbl10.Visible = true;
                    InsertBox10.Visible = true;
                    InsertLbl11.Text = "Unit(s)";
                    InsertLbl11.Visible = true;
                    UnitDrop11.Visible = true;
                    InsertLbl12.Text = "Health Condition";
                    InsertLbl12.Visible = true;
                    HealthCondDrop12.Visible = true;

                    break;
                case 2: // ANIMAL HANDLER -------------------------------
                    InsertLbl1.Text = "Animal ID";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    InsertLbl2.Text = "Employee ID";
                    InsertLbl2.Visible = true;
                    InsertBox2.Visible = true;
                    break;
                case 3: // CONTACT --------------------------------------
                    InsertLbl1.Text = "Phone Number - 10 digit";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    InsertLbl2.Text = "Email Address";
                    InsertLbl2.Visible = true;
                    InsertBox2.Visible = true;
                    InsertLbl3.Text = "Street Address";
                    InsertLbl3.Visible = true;
                    InsertBox3.Visible = true;
                    InsertLbl4.Text = "City";
                    InsertLbl4.Visible = true;
                    InsertBox4.Visible = true;
                    InsertLbl5.Text = "State";
                    InsertLbl5.Visible = true;
                    StateDrop5.Visible = true;              // enum drop
                    InsertLbl6.Text = "Zip Code";
                    InsertLbl6.Visible = true;
                    InsertBox6.Visible = true;
                    break;
                case 4: // DIET ----------------------------------------
                    InsertLbl1.Text = "Diet Type";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;              // enum drop
                    InsertLbl2.Text = "Feeding Size";
                    InsertLbl2.Visible = true;
                    InsertBox2.Visible = true;
                    InsertLbl3.Text = "Unit(s)";
                    InsertLbl3.Visible = true;
                    UnitDrop3.Visible = true;               // enum drop
                    InsertLbl4.Text = "Feedings Per Day";
                    InsertLbl4.Visible = true;
                    InsertBox4.Visible = true;
                    break;
                case 5: // EMPLOYEE ------------------------------------
                    InsertLbl1.Text = "First Name";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    InsertLbl2.Text = "Last Name";
                    InsertLbl2.Visible = true;
                    InsertBox2.Visible = true;
                    InsertLbl3.Text = "Phone Number - 10 digit";
                    InsertLbl3.Visible = true;
                    InsertBox3.Visible = true;
                    InsertLbl4.Text = "Email Address";
                    InsertLbl4.Visible = true;
                    InsertBox4.Visible = true;
                    InsertLbl5.Text = "Street Address";
                    InsertLbl5.Visible = true;
                    InsertBox5.Visible = true;
                    InsertLbl6.Text = "City";
                    InsertLbl6.Visible = true;
                    InsertBox6.Visible = true;
                    InsertLbl7.Text = "State";
                    InsertLbl7.Visible = true;
                    StateDrop7.Visible = true;                // enum drop
                    InsertLbl8.Text = "Zip Code";
                    InsertLbl8.Visible = true;
                    InsertBox8.Visible = true;
                    InsertLbl9.Text = "Job Position";
                    InsertLbl9.Visible = true;
                    JobPosDrop9.Visible = true;               // enum drop
                    InsertLbl10.Text = "Department";
                    InsertLbl10.Visible = true;
                    DeptDrop10.Visible = true;                // enum drop
                    break;
                case 6: // ENUM-DEPARTMENT
                    InsertLbl1.Text = "Department Name";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    break;
                case 7: // ENUM-DIET TYPE
                    InsertLbl1.Text = "Diet Type";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    break;
                case 8: // ENUM-ECOSYSTEM
                    InsertLbl1.Text = "Ecosystem Name";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    break;
                case 9: // ENUM-FACILITY STATUS
                    InsertLbl1.Text = "Facility Status";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    break;
                case 10: // ENUM-FACILITY TYPE
                    InsertLbl1.Text = "Facility Type";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    break;
                case 11: // ENUM-HEALTH CONDITION
                    InsertLbl1.Text = "Health Condition";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    break;
                case 12: // ENUM-JOB POSITION
                    InsertLbl1.Text = "Job Title";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    break;
                case 13: // ENUM-MEDICATION
                    InsertLbl1.Text = "Medicine Name";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    break;
                case 14: // ENUM-MEMBERSHIP STATUS
                    InsertLbl1.Text = "Membership Status";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    break;
                case 15: // ENUM-MEMBERSHIP TYPE
                    InsertLbl1.Text = "Type of Membership";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    break;
                case 16: // ENUM-SECTION
                    InsertLbl1.Text = "Section Name";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    break;
                case 17: // ENUM-SPECIES
                    InsertLbl1.Text = "Species Name";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    break;
                case 18: // ENUM-WORK ORDER TYPE
                    InsertLbl1.Text = "Order Type";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    InsertLbl2.Text = "Facility Type";
                    InsertLbl2.Visible = true;
                    FactTypeDrop2.Visible = true;                // enum drop
                    break;
                case 19: // EXHIBIT
                    InsertLbl1.Text = "Exhibit Name";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    InsertLbl2.Text = "Exhibit Size";
                    InsertLbl2.Visible = true;
                    InsertBox2.Visible = true;
                    InsertLbl3.Text = "Unit(s)";
                    InsertLbl3.Visible = true;
                    UnitDrop3.Visible = true;                // enum drop
                    InsertLbl4.Text = "Ecosystem";
                    InsertLbl4.Visible = true;
                    EcoDrop4.Visible = true;                 // enum drop
                    InsertLbl5.Text = "Section";
                    InsertLbl5.Visible = true;
                    SectDrop5.Visible = true;                // enum drop
                    break;
                case 20: // FACILITY
                    InsertLbl1.Text = "Facility Type";
                    InsertLbl1.Visible = true;
                    FactTypeDrop1.Visible = true;               // enum drop
                    InsertLbl2.Text = "Facility Status";
                    InsertLbl2.Visible = true;
                    FactStatDrop2.Visible = true;               // enum drop
                    InsertLbl3.Text = "Section";
                    InsertLbl3.Visible = true;
                    SectDrop3.Visible = true;                   // enum drop
                    InsertLbl4.Text = "Facility Name";
                    InsertLbl4.Visible = true;
                    InsertBox4.Visible = true;
                    break;
                case 21: // HEALTH PROFILE
                    InsertLbl1.Text = "Sex";
                    InsertLbl1.Visible = true;
                    InsertBox1.Visible = true;
                    InsertLbl2.Text = "Date of Birth";
                    InsertLbl2.Visible = true;
                    InsertBox2.Text = "YYYY-MM-DD";
                    InsertBox2.Visible = true;
                    InsertLbl3.Text = "Weight";
                    InsertLbl3.Visible = true;
                    InsertBox3.Visible = true;
                    InsertLbl4.Text = "Unit(s)";
                    InsertLbl4.Visible = true;
                    UnitDrop4.Visible = true;                   // enum drop
                    InsertLbl5.Text = "Height";
                    InsertLbl5.Visible = true;
                    InsertBox5.Visible = true;
                    InsertLbl6.Text = "Unit(s)";
                    InsertLbl6.Visible = true;
                    UnitDrop6.Visible = true;                   // enum drop
                    InsertLbl7.Text = "Health Condition";
                    InsertLbl7.Visible = true;
                    HealthCondDrop7.Visible = true;             // enum drop
                    break;
                case 22: // MEMBERSHIP
                    InsertLbl1.Text = "Type of Membership";
                    MemTypeDrop1.Visible = true;
                    InsertLbl2.Text = "First Name";
                    InsertBox2.Visible = true;
                    InsertLbl3.Text = "Last Name";
                    InsertBox3.Visible = true;
                    InsertLbl4.Text = "Phone Number-10 digit";
                    InsertBox4.Visible = true;
                    InsertLbl5.Text = "Email Address";
                    InsertBox5.Visible = true;
                    InsertLbl6.Text = "Street Address";
                    InsertBox6.Visible = true;
                    InsertLbl7.Text = "City";
                    InsertBox7.Visible = true;
                    InsertLbl8.Text = "State";
                    StateDrop8.Visible = true;
                    InsertLbl9.Text = "Zip Code";
                    InsertBox9.Visible = true;
                    InsertLbl10.Text = "Registration Date";
                    InsertBox10.Text = "YYYY-MM-DD";
                    InsertBox10.Visible = true;
                    InsertLbl11.Text = "Membership Status";
                    MemStatDrop11.Visible = true;
                    InsertLbl1.Visible = true;
                    InsertLbl2.Visible = true;
                    InsertLbl3.Visible = true;
                    InsertLbl4.Visible = true;
                    InsertLbl5.Visible = true;
                    InsertLbl6.Visible = true;
                    InsertLbl7.Visible = true;
                    InsertLbl8.Visible = true;
                    InsertLbl9.Visible = true;
                    InsertLbl10.Visible = true;
                    InsertLbl11.Visible = true;
                    break;
                case 23: // USER LOGIN
                    InsertLbl1.Text = "Employee ID";
                    EmployeeDrop.Visible = true;
                    InsertLbl1.Visible = true;
                    InsertLbl2.Text = "Username";
                    InsertLbl2.Visible = true;
                    InsertBox2.Visible = true;
                    InsertLbl3.Text = "Password";
                    InsertLbl3.Visible = true;
                    InsertBox3.Visible = true;
                    break;
                case 24: // WORK ORDER
                    InsertLbl1.Text = "Order Type";
                    InsertLbl1.Visible = true;
                    OrderDrop1.Visible = true;
                    InsertLbl2.Text = "Order Date";
                    InsertLbl2.Visible = true;
                    InsertBox2.Text = "YYYY-MM-DD";
                    InsertBox2.Visible = true;
                    InsertLbl3.Text = "Facility";
                    InsertLbl3.Visible = true;
                    FacilityDrop.Visible = true;
                    InsertLbl4.Text = "Ordered By";
                    InsertLbl4.Visible = true;
                    InsertBox4.Visible = true;
                    InsertLbl5.Text = "Assigned To";
                    InsertLbl5.Visible = true;
                    InsertBox5.Visible = true;
                    break;
            }
        }

        // BUTTON ACTIONS & EVENTS
        protected void CreateBtn_Click(object sender, EventArgs e)
        {
            int index = InsertDropDown.SelectedIndex;
            String query = "";
            String part1 = "";
            String part2 = "";
            String input1 = "";
            String input2 = "";
            String input3 = "";
            String input4 = "";
            String input5 = "";
            String input6 = "";
            String input7 = "";
            String input8 = "";
            String input9 = "";
            String input10 = "";
            String input11 = "";
            String input12 = "";
            String input13 = "";
            String input14 = "";

            MySqlConnection connection = new MySqlConnection(ConnString);
            MySqlCommand command;

            switch (index)
            {
                case 0: // DEFAULT - NULL
                    break;
                case 1: // ANIMAL
                    input1 = GenerateRecordID("animal_id", "animal");
                    input2 = InsertBox1.Text.Trim();
                    input3 = AddIndex(SpecDrop2.SelectedIndex).ToString();
                    input4 = GenerateRecordID("profile_id", "health_profile");
                    input5 = AddIndex(DietTypeDrop3.SelectedIndex).ToString();
                    input6 = AddIndex(ExhibDrop4.SelectedIndex).ToString();
                    input7 = InsertBox5.Text.Trim();
                    input8 = InsertBox6.Text.Trim();
                    input9 = InsertBox7.Text.Trim();
                    input10 = InsertBox8.Text.Trim();
                    input11 = UnitDrop9.SelectedValue.ToString();
                    input12 = InsertBox10.Text.Trim();
                    input13 = UnitDrop11.SelectedValue.ToString();
                    input14 = AddIndex(HealthCondDrop12.SelectedIndex).ToString();
                    part1 = "INSERT INTO health_profile VALUES(@profile_id, @sex, @dob, @weight, @weight_unit, @height, @height_unit, @health_condition);";
                    part2 = "INSERT INTO animal VALUES (@animal_id, @animal_name, @species, @health_profile, @diet, @exhibit, @date);";
                    query = part1 + "\n" + part2;
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@profile_id", input4);
                    command.Parameters.AddWithValue("@sex", input8);
                    command.Parameters.AddWithValue("@dob", input9);
                    command.Parameters.AddWithValue("@weight", input10);
                    command.Parameters.AddWithValue("@weight_unit", input11);
                    command.Parameters.AddWithValue("@height", input12);
                    command.Parameters.AddWithValue("@height_unit", input13);
                    command.Parameters.AddWithValue("@health_condition", input14);
                    command.Parameters.AddWithValue("@animal_id", input1);
                    command.Parameters.AddWithValue("@animal_name", input2);
                    command.Parameters.AddWithValue("@species", input3);
                    command.Parameters.AddWithValue("@health_profile", input4);
                    command.Parameters.AddWithValue("@diet", input5);
                    command.Parameters.AddWithValue("@exhibit", input6);
                    command.Parameters.AddWithValue("@date", input7);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 2: // ANIMAL HANDLER
                    input1 = InsertBox1.Text.Trim();
                    input2 = InsertBox2.Text.Trim();
                    query = "INSERT INTO animal_handler VALUES (@one, @two)";
                    InsertEnum(query, connection, input1, input2);
                    break;
                case 3: // CONTACT
                    input1 = InsertBox1.Text.Trim();
                    input2 = InsertBox2.Text.Trim();
                    input3 = InsertBox3.Text.Trim();
                    input4 = InsertBox4.Text.Trim();
                    input5 = StateDrop5.SelectedValue.ToString();
                    input6 = InsertBox6.Text.Trim();
                    query = "INSERT INTO contact VALUES (@one, @two, @three, @four, @five, @six)";
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
                case 4: // DIET
                    input1 = GenerateRecordID("diet_id", "diet");
                    input2 = AddIndex(DietTypeDrop1.SelectedIndex).ToString();
                    input3 = InsertBox2.Text.Trim();
                    input4 = UnitDrop3.SelectedValue.ToString();
                    input5 = InsertBox4.Text.Trim();
                    query = "INSERT INTO diet VALUES (@one, @two, @three, @four, @five";
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
                case 5: // EMPLOYEE
                    input1 = GenerateRecordID("empl_id", "employee");
                    input2 = InsertBox1.Text;
                    input3 = InsertBox2.Text;
                    input4 = InsertBox3.Text;
                    input5 = InsertBox4.Text;
                    input6 = InsertBox5.Text;
                    input7 = InsertBox6.Text;
                    input8 = StateDrop7.SelectedValue.ToString();
                    input9 = InsertBox8.Text;
                    input10 = AddIndex(JobPosDrop9.SelectedIndex).ToString();
                    input11 = AddIndex(DeptDrop10.SelectedIndex).ToString();
                    part1 = "INSERT INTO contact VALUES (@phone1, @email, @address, @city, @state, @zip);";
                    part2 = "INSERT INTO employee VALUES (@empl_id, @first, @last, @phone2, @title, @dept);";
                    query = part1 + "\n" + part2;
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@empl_id", input1);
                    command.Parameters.AddWithValue("@first", input2);
                    command.Parameters.AddWithValue("@last", input3);
                    command.Parameters.AddWithValue("@phone1", input4);
                    command.Parameters.AddWithValue("@phone2", input4);
                    command.Parameters.AddWithValue("@email", input5);
                    command.Parameters.AddWithValue("@address", input6);
                    command.Parameters.AddWithValue("@city", input7);
                    command.Parameters.AddWithValue("@state", input8);
                    command.Parameters.AddWithValue("@zip", input9);
                    command.Parameters.AddWithValue("@title", input10);
                    command.Parameters.AddWithValue("@dept", input11);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 6: // ENUM-DEPARTMENT
                    input1 = GenerateRecordID("dept_id", "enum_department");
                    input2 = InsertBox1.Text.Trim();
                    query = "INSERT INTO enum_department VALUES (@one, @two);";
                    InsertEnum(query, connection, input1, input2);
                    break;
                case 7: // ENUM-DIET TYPE
                    input1 = GenerateRecordID("diet_type_id", "enum_diet_type");
                    input2 = InsertBox1.Text.Trim();
                    query = "INSERT INTO enum_diet_type VALUES (@one, @two);";
                    InsertEnum(query, connection, input1, input2);
                    break;
                case 8: // ENUM-ECOSYSTEM
                    input1 = GenerateRecordID("ecosystem_id", "enum_ecosystem");
                    input2 = InsertBox1.Text.Trim();
                    query = "INSERT INTO enum_ecosystem VALUES (@one, @two);";
                    InsertEnum(query, connection, input1, input2);
                    break;
                case 9: // ENUM-FACILITY STATUS
                    input1 = GenerateRecordID("facility_status_id", "enum_facility_status");
                    input2 = InsertBox1.Text.Trim();
                    query = "INSERT INTO enum_facility_status VALUES (@one, @two);";
                    InsertEnum(query, connection, input1, input2);
                    break;
                case 10: // ENUM-FACILITY TYPE
                    input1 = GenerateRecordID("facility_type_id", "enum_facility_type");
                    input2 = InsertBox1.Text.Trim();
                    query = "INSERT INTO enum_facility_type VALUES (@one, @two);";
                    InsertEnum(query, connection, input1, input2);
                    break;
                case 11: // ENUM-HEALTH CONDITION
                    input1 = GenerateRecordID("condition_id", "enum_health_condition");
                    input2 = InsertBox1.Text.Trim();
                    query = "INSERT INTO enum_health_condition VALUES (@one, @two);";
                    InsertEnum(query, connection, input1, input2);
                    break;
                case 12: // ENUM-JOB POSITION
                    input1 = GenerateRecordID("position_id", "enum_job_position");
                    input2 = InsertBox1.Text.Trim();
                    query = "INSERT INTO enum_job_position VALUES (@one, @two);";
                    InsertEnum(query, connection, input1, input2);
                    break;
                case 13: // ENUM-MEDICATION
                    input1 = GenerateRecordID("med_id", "enum_medication");
                    input2 = InsertBox1.Text.Trim();
                    query = "INSERT INTO enum_medication VALUES (@one, @two);";
                    InsertEnum(query, connection, input1, input2);
                    break;
                case 14: // ENUM-MEMBERSHIP STATUS
                    input1 = GenerateRecordID("member_status_id", "enum_membership_status");
                    input2 = InsertBox1.Text.Trim();
                    query = "INSERT INTO enum_membership_status VALUES (@one, @two);";
                    InsertEnum(query, connection, input1, input2);
                    break;
                case 15: // ENUM-MEMBERSHIP TYPE
                    input1 = GenerateRecordID("member_type_id", "enum_membership_type");
                    input2 = InsertBox1.Text.Trim();
                    query = "INSERT INTO enum_membership_type VALUES (@one, @two);";
                    InsertEnum(query, connection, input1, input2);
                    break;
                case 16: // ENUM-SECTION
                    input1 = GenerateRecordID("section_id", "enum_section");
                    input2 = InsertBox1.Text.Trim();
                    query = "INSERT INTO enum_section VALUES (@one, @two);";
                    InsertEnum(query, connection, input1, input2);
                    break;
                case 17: // ENUM-SPECIES
                    input1 = GenerateRecordID("species_id", "enum_species");
                    input2 = InsertBox1.Text.Trim();
                    query = "INSERT INTO enum_species VALUES (@one, @two);";
                    InsertEnum(query, connection, input1, input2);
                    break;
                case 18: // ENUM-WORK ORDER TYPE
                    input1 = GenerateRecordID("order_id", "enum_work_order_type");
                    input2 = InsertBox1.Text.Trim();
                    input3 = InsertBox2.Text.Trim();
                    query = "INSERT INTO enum_work_order_type VALUES (@one, @two, @three);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 19: // EXHIBIT
                    input1 = GenerateRecordID("exhibit_id", "exhibit");
                    input2 = InsertBox1.Text.Trim();
                    input3 = InsertBox2.Text.Trim();
                    input4 = UnitDrop3.SelectedValue.ToString();
                    input5 = AddIndex(EcoDrop4.SelectedIndex).ToString();
                    input6 = AddIndex(SectDrop5.SelectedIndex).ToString();
                    query = "INSERT INTO exhibit VALUES (@exhib_id, @name, @size, @unit, @eco, @section);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@exhib_id", input1);
                    command.Parameters.AddWithValue("@name", input2);
                    command.Parameters.AddWithValue("@size", input3);
                    command.Parameters.AddWithValue("@unit", input4);
                    command.Parameters.AddWithValue("@eco", input5);
                    command.Parameters.AddWithValue("@section", input6);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 20: // FACILITY
                    input1 = GenerateRecordID("facility_id", "facility");
                    input2 = AddIndex(FactTypeDrop1.SelectedIndex).ToString();
                    input3 = AddIndex(FactStatDrop2.SelectedIndex).ToString();
                    input4 = AddIndex(SectDrop3.SelectedIndex).ToString();
                    input5 = InsertBox4.Text.Trim();
                    query = "INSERT INTO facility VALUES (@fact_id, @type, @status, @section, @name);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@fact_id", input1);
                    command.Parameters.AddWithValue("@type", input2);
                    command.Parameters.AddWithValue("@status", input3);
                    command.Parameters.AddWithValue("@section", input4);
                    command.Parameters.AddWithValue("@name", input5);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 21: // HEALTH PROFILE
                    input1 = GenerateRecordID("profile_id", "health_profile");
                    input2 = InsertBox1.Text.Trim();
                    input3 = InsertBox2.Text.Trim();
                    input4 = InsertBox3.Text.Trim();
                    input5 = UnitDrop4.SelectedValue.ToString();
                    input6 = InsertBox5.Text.Trim();
                    input7 = UnitDrop6.SelectedValue.ToString();
                    input8 = AddIndex(HealthCondDrop7.SelectedIndex).ToString();
                    query = "INSERT INTO health_profile VALUES (@id, @sex, @dob, @weight, @unit1, @height, @unit2, @cond);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", input1);
                    command.Parameters.AddWithValue("@sex", input2);
                    command.Parameters.AddWithValue("@dob", input3);
                    command.Parameters.AddWithValue("@weight", input4);
                    command.Parameters.AddWithValue("@unit1", input5);
                    command.Parameters.AddWithValue("@height", input6);
                    command.Parameters.AddWithValue("@unit2", input7);
                    command.Parameters.AddWithValue("@cond", input8);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 22: // MEMBERSHIP
                    input1 = GenerateRecordID("member_id", "membership");
                    input2 = AddIndex(MemTypeDrop1.SelectedIndex).ToString();
                    input3 = InsertBox2.Text.Trim();
                    input4 = InsertBox3.Text.Trim();
                    input5 = InsertBox4.Text.Trim();
                    input6 = InsertBox5.Text.Trim();
                    input7 = InsertBox6.Text.Trim();
                    input8 = InsertBox7.Text.Trim();
                    input9 = StateDrop8.SelectedValue.ToString();
                    input10 = InsertBox9.Text.Trim();
                    input11 = InsertBox10.Text.Trim();
                    input12 = AddIndex(MemStatDrop11.SelectedIndex).ToString();
                    part1 = "INSERT INTO contact VALUES (@phone1, @email, @address, @city, @state, @zip);";
                    part2 = "INSERT INTO membership VALUES (@id, @type, @first, @last, @phone2, @date, @status);";
                    query = part1 + "\n" + part2;
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", input1);
                    command.Parameters.AddWithValue("@type", input2);
                    command.Parameters.AddWithValue("@first", input3);
                    command.Parameters.AddWithValue("@last", input4);
                    command.Parameters.AddWithValue("@phone1", input5);
                    command.Parameters.AddWithValue("@phone2", input5);
                    command.Parameters.AddWithValue("@email", input6);
                    command.Parameters.AddWithValue("@address", input7);
                    command.Parameters.AddWithValue("@city", input8);
                    command.Parameters.AddWithValue("@state", input9);
                    command.Parameters.AddWithValue("@zip", input10);
                    command.Parameters.AddWithValue("@date", input11);
                    command.Parameters.AddWithValue("@status", input12);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 23: // USER LOGIN
                    input1 = EmployeeDrop.SelectedValue.ToString();
                    input2 = InsertBox2.Text.Trim();
                    input3 = InsertBox3.Text.Trim();
                    query = "INSERT INTO user_login VALUES (@id, @user, @pwd);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", input1);
                    command.Parameters.AddWithValue("@type", input2);
                    command.Parameters.AddWithValue("@first", input3);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 24: // WORK ORDER
                    input1 = GenerateRecordID("order_id", "work_order");
                    input2 = AddIndex(OrderDrop1.SelectedIndex).ToString();
                    input3 = InsertBox2.Text.Trim();
                    input4 = AddIndex(FacilityDrop.SelectedIndex).ToString();
                    input5 = EmployeeDrop4.SelectedValue.ToString();
                    input6 = EmployeeDrop5.SelectedValue.ToString();
                    query = "INSERT INTO work_order VALUES (@id, @type, @date, @fact, @by, @for);";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", input1);
                    command.Parameters.AddWithValue("@type", input2);
                    command.Parameters.AddWithValue("@date", input3);
                    command.Parameters.AddWithValue("@fact", input4);
                    command.Parameters.AddWithValue("@by", input5);
                    command.Parameters.AddWithValue("@for", input6);
                    AttemptTransaction(command);
                    connection.Close();
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

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int index = QueryDropDown.SelectedIndex;
            String query = "";
            String input1 = KeyBox.Text.Trim();
            String input2 = UpdateBox1.Text.Trim();
            String input3 = UpdateBox2.Text.Trim();
            String input4 = UpdateBox3.Text.Trim();
            String input5 = UpdateBox4.Text.Trim();
            String input6 = UpdateBox5.Text.Trim();
            String input7 = UpdateBox6.Text.Trim();
            String input8 = UpdateBox7.Text.Trim();

            MySqlConnection connection = new MySqlConnection(ConnString);
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
                case 2: // ANIMAL HANDLER
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
                case 3: // CONTACT
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
                case 4: // DIET
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
                case 5: // EMPLOYEE
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
                case 6: // ENUM DEPARTMENT

                    query = "UPDATE enum_department SET " +
                        "dept_name = @two" + " WHERE " +
                        "dept_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 7: // ENUM DIET TYPE
                    query = "UPDATE enum_diet_type SET " +
                        "diet_type_name = @two" + " WHERE " +
                        "diet_type_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 8: // ENUM ECOSYSTEM
                    query = "UPDATE enum_ecosystem SET " +
                        "ecosystem_name = @two" + " WHERE " +
                        "ecosystem_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 9: // ENUM FACILITY STATUS
                    query = "UPDATE enum__facility_status SET " +
                        "facility_status_name = @two" + " WHERE " +
                        "facility_status_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 10: // ENUM FACILITY TYPE
                    query = "UPDATE enum_facility_type SET " +
                        "facility_type_name = @two" + " WHERE " +
                        "facility_type_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 11: // HEALTH CONDITION
                    query = "UPDATE enum_health_condition SET " +
                        "condition_name = @two" + " WHERE " +
                        "condition_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 12: // ENUM JOB POSITION
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
                case 13: // ENUM MEDICATION
                    query = "UPDATE enum_medication SET " +
                        "med_name = @two" + " WHERE " +
                        "med_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    AttemptTransaction(command);
                    connection.Close();

                    break;
                case 14: // ENUM MEMBERSHIP STATUS
                    query = "UPDATE enum_membership_status SET " +
                        "member_status_name = @two" + " WHERE " +
                        "member_status_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 15: // ENUM MEMBERSHIP TYPE
                    query = "UPDATE enum_membership_type SET " +
                        "member_type_name = @two" + " WHERE " +
                        "member_type_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 16: // ENUM SECTION
                    query = "UPDATE enum_section SET " +
                        "section_name = @two" + " WHERE " +
                        "section_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 17: // ENUM SPECIES
                    query = "UPDATE enum_species SET " +
                        "species_name = @two" + " WHERE " +
                        "species_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 18: // ENUM STATE
                    query = "UPDATE enum_state SET " +
                        "state_name = @two" + " WHERE " +
                        "state_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 19: // ENUM UNIT MEASURE
                    query = "UPDATE enum_unit_measure SET " +
                        "unit_name = @two" + " WHERE " +
                        "unit_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 20: // ENUM WORK ORDER TYPE
                    query = "UPDATE enum_work_order_type SET " +
                        "order_type_name = @two" + ", " +
                        "facility_type = @three" + " WHERE " +
                        "order_type_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    AttemptTransaction(command);
                    connection.Close();
                    break;

                case 21: // EXHIBIT
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
                case 22: // FACILITY
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
                case 23: // HEALTH PROFILE
                    query = "UPDATE health_profile SET " +
                        "sex = @two" + ", " +
                        "DOB = @three" + ", " +
                        "weight = @four" + ", " +
                        "weight_unit = @five" + ", " +
                        "height = @six" + ", " +
                        "height_unit = @seven" + ", " +
                        "health_condition = @eight" + " WHERE " +
                        "profile_id = @one;";
                    connection.Open();
                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@one", input1);
                    command.Parameters.AddWithValue("@two", input2);
                    command.Parameters.AddWithValue("@three", input3);
                    command.Parameters.AddWithValue("@four", input4);
                    command.Parameters.AddWithValue("@five", input5);
                    command.Parameters.AddWithValue("@six", input6);
                    command.Parameters.AddWithValue("@seven", input7);
                    command.Parameters.AddWithValue("@eight", input8);
                    AttemptTransaction(command);
                    connection.Close();
                    break;
                case 24: // MEMBERSHIP
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
                case 25: // PRESCRIPTION

                    query = "UPDATE prescription SET " +
                        "health_profile = @two" + ", " +
                        "medication = @three" + ", " +
                        "dosage_size = @four" + ", " +
                        "dosage_unit = @five" + ", " +
                        "doses_per_week = @six" + " WHERE " +
                        "prescription_id = @one;";
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
                case 26: // USER LOGIN
                    query = "UPDATE user_login SET " +
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
                case 27: // WORK ORDER
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
            PopulateUpdateForm();
            String key = KeyTextBox.Text;
            int index = QueryDropDown.SelectedIndex;
            switch (index)
            {
                case 1:
                    ShowDataRecord("animal", "animal_id", key);
                    break;
                case 2:
                    ShowDataRecord("animal_handler", "animal_id", key);
                    break;
                case 3:
                    ShowDataRecord("contact", "phone_no", key);
                    break;
                case 4:
                    ShowDataRecord("diet", "diet_id", key);
                    break;
                case 5:
                    ShowDataRecord("employee", "empl_id", key);
                    break;
                case 6:
                    ShowDataRecord("enum_department", "dept_id", key);
                    break;
                case 7:
                    ShowDataRecord("enum_diet_type", "diet_type_id", key);
                    break;
                case 8:
                    ShowDataRecord("enum_ecosystem", "ecosystem_id", key);
                    break;
                case 9:
                    ShowDataRecord("enum_facility_status", "facility_status_id", key);
                    break;
                case 10:
                    ShowDataRecord("enum_facility_type", "facility_type_id", key);
                    break;
                case 11:
                    ShowDataRecord("enum_health_condition", "condition_id", key);
                    break;
                case 12:
                    ShowDataRecord("enum_job_position", "position_id", key);
                    break;
                case 13:
                    ShowDataRecord("enum_medication", "med_id", key);
                    break;
                case 14:
                    ShowDataRecord("enum_membership_status", "member_status_id", key);
                    break;
                case 15:
                    ShowDataRecord("enum_membership_type", "member_type_id", key);
                    break;
                case 16:
                    ShowDataRecord("enum_section", "section_id", key);
                    break;
                case 17:
                    ShowDataRecord("enum_species", "species_id", key);
                    break;
                case 18:
                    ShowDataRecord("enum_state", "state_id", key);
                    break;
                case 19:
                    ShowDataRecord("enum_unit_measure", "unit_id", key);
                    break;
                case 20:
                    ShowDataRecord("enum_work_order_type", "order_type_id", key);
                    break;
                case 21:
                    ShowDataRecord("exhibit", "exhibit_id", key);
                    break;
                case 22:
                    ShowDataRecord("facility", "facility_id", key);
                    break;
                case 23:
                    ShowDataRecord("health_profile", "profile_id", key);
                    break;
                case 24:
                    ShowDataRecord("membership", "member_id", key);
                    break;
                case 25:
                    ShowDataRecord("prescription", "prescription_id", key);
                    break;
                case 26:
                    ShowDataRecord("user_login", "user_id", key);
                    break;
                case 27:
                    ShowDataRecord("work_order", "order_id", key);
                    break;
                default:
                    break;
            }
        }
        protected void ViewTableBtn_Click(object sender, EventArgs e)
        {
            PopulateUpdateForm();
            int index = QueryDropDown.SelectedIndex;
            switch (index)
            {
                case 1:
                    ShowDataTable("animal");
                    break;
                case 2:
                    ShowDataTable("animal_handler");
                    break;
                case 3:
                    ShowDataTable("contact");
                    break;
                case 4:
                    ShowDataTable("diet");
                    break;
                case 5:
                    ShowDataTable("employee");
                    break;
                case 6:
                    ShowDataTable("enum_department");
                    break;
                case 7:
                    ShowDataTable("enum_diet_type");
                    break;
                case 8:
                    ShowDataTable("enum_ecosystem");
                    break;
                case 9:
                    ShowDataTable("enum_facility_status");
                    break;
                case 10:
                    ShowDataTable("enum_facility_type");
                    break;
                case 11:
                    ShowDataTable("enum_health_condition");
                    break;
                case 12:
                    ShowDataTable("enum_job_position");
                    break;
                case 13:
                    ShowDataTable("enum_medication");
                    break;
                case 14:
                    ShowDataTable("enum_membership_status");
                    break;
                case 15:
                    ShowDataTable("enum_membership_type");
                    break;
                case 16:
                    ShowDataTable("enum_section");
                    break;
                case 17:
                    ShowDataTable("enum_species");
                    break;
                case 18:
                    ShowDataTable("enum_state");
                    break;
                case 19:
                    ShowDataTable("enum_unit_measure");
                    break;
                case 20:
                    ShowDataTable("enum_work_order_type");
                    break;
                case 21:
                    ShowDataTable("exhibit");
                    break;
                case 22:
                    ShowDataTable("facility");
                    break;
                case 23:
                    ShowDataTable("health_profile");
                    break;
                case 24:
                    ShowDataTable("membership");
                    break;
                case 25:
                    ShowDataTable("prescription");
                    break;
                case 26:
                    ShowDataTable("user_login");
                    break;
                case 27:
                    ShowDataTable("work_order");
                    break;
                default:
                    break;
            }
        }

        // RECURSIVE METHODS
        protected String GenerateRecordID(String primaryKey, String tableName)
        {
            String result;
            String query = "SELECT MAX(" + primaryKey + ") FROM " + tableName + ";";
            result = ExecuteIDReader(query);
            return result;
        }
        protected String ExecuteIDReader(String query)
        {
            String result = "error";
            int response = 0;
            MySqlConnection connection = new MySqlConnection(ConnString);
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
        protected void InsertEnum(String query, MySqlConnection conn, String in1, String in2)
        {
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            com.Parameters.AddWithValue("@one", in1);
            com.Parameters.AddWithValue("@two", in2);
            AttemptTransaction(com);
            conn.Close();
        }
        protected void ShowDataRecord(String table, String primaryKey, String record_id)
        {
            String query = "SELECT * FROM " + table + " WHERE " + primaryKey + " = @key_id;";
            MySqlConnection connection = new MySqlConnection(ConnString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@key_id", record_id);
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable adapTable = new DataTable();
                adapter.Fill(adapTable);
                RecordGrid.DataSource = adapTable;
                RecordGrid.DataBind();
            }
            catch
            {
                InsertDialog.Text = "Record Not Found!";
            }

        }
        protected void ShowDataTable(String table)
        {
            String query = "SELECT * FROM " + table;
            MySqlConnection connection = new MySqlConnection(ConnString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            TableGrid.DataSource = reader;
            TableGrid.DataBind();
            connection.Close();
        }
        protected void PopulateUpdateForm()
        {
            PopulateUpdateLabels();
            UpdateBtn.Visible = true;
            int index = QueryDropDown.SelectedIndex;
            switch (index)
            {
                case 0: // DEFAULT
                    break;
                case 1: // ANIMAL
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    UpdateBox2.Visible = true;
                    UpdateBox3.Visible = true;
                    UpdateBox4.Visible = true;
                    UpdateBox5.Visible = true;
                    UpdateBox6.Visible = true;
                    break;
                case 2: // ANIMAL HANDLER
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    break;
                case 3: // CONTACT
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    UpdateBox2.Visible = true;
                    UpdateBox3.Visible = true;
                    UpdateBox4.Visible = true;
                    UpdateBox5.Visible = true;
                    break;
                case 4: // DIET
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    UpdateBox2.Visible = true;
                    UpdateBox3.Visible = true;
                    UpdateBox4.Visible = true;
                    break;
                case 5: // EMPLOYEE
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    UpdateBox2.Visible = true;
                    UpdateBox3.Visible = true;
                    UpdateBox4.Visible = true;
                    UpdateBox5.Visible = true;
                    break;
                case 6: // ENUM DEPARTMENT
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    break;
                case 7: // ENUM DIET TYPE
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    break;
                case 8: // ENUM ECOSYSTEM
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    break;
                case 9: // ENUM FACILITY STATUS
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    break;
                case 10: // ENUM FACILITY TYPE
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    break;
                case 11: // HEALTH CONDITION
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    break;
                case 12: // ENUM JOB POSITION
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    break;
                case 13: // ENUM MEDICATION
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    break;
                case 14: // ENUM MEMBERSHIP STATUS
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    break;
                case 15: // ENUM MEMBERSHIP TYPE
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    break;
                case 16: // ENUM SECTION
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    break;
                case 17: // ENUM SPECIES
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    break;
                case 18: // ENUM STATE
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    break;
                case 19: // ENUM UNIT MEASURE
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    break;
                case 20: // ENUM WORK ORDER
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    UpdateBox2.Visible = true;
                    break;
                case 21: // EXHIBIT
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    UpdateBox2.Visible = true;
                    UpdateBox3.Visible = true;
                    UpdateBox4.Visible = true;
                    UpdateBox5.Visible = true;
                    break;
                case 22: // FACILITY
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    UpdateBox2.Visible = true;
                    UpdateBox3.Visible = true;
                    UpdateBox4.Visible = true;
                    break;
                case 23: // HEALTH PROFILE
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    UpdateBox2.Visible = true;
                    UpdateBox3.Visible = true;
                    UpdateBox4.Visible = true;
                    UpdateBox5.Visible = true;
                    UpdateBox6.Visible = true;
                    UpdateBox7.Visible = true;
                    break;
                case 24: // MEMBERSHIP
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    UpdateBox2.Visible = true;
                    UpdateBox3.Visible = true;
                    UpdateBox4.Visible = true;
                    UpdateBox5.Visible = true;
                    UpdateBox6.Visible = true;
                    break;
                case 25: // PRESCRIPTION
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    UpdateBox2.Visible = true;
                    UpdateBox3.Visible = true;
                    UpdateBox4.Visible = true;
                    UpdateBox5.Visible = true;
                    UpdateBox6.Visible = true;
                    break;
                case 26: // USER LOGIN
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    UpdateBox2.Visible = true;
                    break;
                case 27: // WORK ORDER
                    KeyBox.Visible = true;
                    UpdateBox1.Visible = true;
                    UpdateBox2.Visible = true;
                    UpdateBox3.Visible = true;
                    UpdateBox4.Visible = true;
                    UpdateBox5.Visible = true;
                    break;
            }
        }
        protected void ClearInsertForm()
        {
            // HIDE FORM LABELS
            InsertLbl1.Visible = false;
            InsertLbl2.Visible = false;
            InsertLbl3.Visible = false;
            InsertLbl4.Visible = false;
            InsertLbl5.Visible = false;
            InsertLbl6.Visible = false;
            InsertLbl7.Visible = false;
            InsertLbl8.Visible = false;
            InsertLbl9.Visible = false;
            InsertLbl10.Visible = false;
            InsertLbl11.Visible = false;
            InsertLbl12.Visible = false;
            InsertLbl13.Visible = false;
            InsertLbl14.Visible = false;
            InsertLbl15.Visible = false;
            InsertLbl16.Visible = false;
            InsertLbl17.Visible = false;
            InsertLbl18.Visible = false;
            InsertLbl19.Visible = false;
            InsertLbl20.Visible = false;

            // RESET AND HIDE FORM TEXTBOXES
            InsertBox1.Text = "";
            InsertBox2.Text = "";
            InsertBox3.Text = "";
            InsertBox4.Text = "";
            InsertBox5.Text = "";
            InsertBox6.Text = "";
            InsertBox7.Text = "";
            InsertBox8.Text = "";
            InsertBox9.Text = "";
            InsertBox10.Text = "";
            InsertBox11.Text = "";
            InsertBox12.Text = "";
            InsertBox13.Text = "";
            InsertBox14.Text = "";
            InsertBox15.Text = "";
            InsertBox16.Text = "";
            InsertBox17.Text = "";
            InsertBox18.Text = "";
            InsertBox19.Text = "";
            InsertBox20.Text = "";
            InsertBox1.Visible = false;
            InsertBox2.Visible = false;
            InsertBox3.Visible = false;
            InsertBox4.Visible = false;
            InsertBox5.Visible = false;
            InsertBox6.Visible = false;
            InsertBox7.Visible = false;
            InsertBox8.Visible = false;
            InsertBox9.Visible = false;
            InsertBox10.Visible = false;
            InsertBox11.Visible = false;
            InsertBox12.Visible = false;
            InsertBox13.Visible = false;
            InsertBox14.Visible = false;
            InsertBox15.Visible = false;
            InsertBox16.Visible = false;
            InsertBox17.Visible = false;
            InsertBox18.Visible = false;
            InsertBox19.Visible = false;
            InsertBox20.Visible = false;
            // HIDE DROPDOWNS
            EmployeeDrop.Visible = false;
            FacilityDrop.Visible = false;
            DietTypeDrop1.Visible = false;
            FactTypeDrop1.Visible = false;
            MemTypeDrop1.Visible = false;
            OrderDrop1.Visible = false;
            FactStatDrop2.Visible = false;
            FactTypeDrop2.Visible = false;
            SpecDrop2.Visible = false;
            SectDrop3.Visible = false;
            UnitDrop3.Visible = false;
            EcoDrop4.Visible = false;
            ExhibDrop4.Visible = false;
            UnitDrop4.Visible = false;
            EmployeeDrop4.Visible = false;
            EmployeeDrop5.Visible = false;
            SectDrop5.Visible = false;
            StateDrop5.Visible = false;
            UnitDrop6.Visible = false;
            StateDrop7.Visible = false;
            UnitDrop7.Visible = false;
            HealthCondDrop7.Visible = false;
            HealthCondDrop8.Visible = false;
            StateDrop8.Visible = false;
            UnitDrop8.Visible = false;
            HealthCondDrop9.Visible = false;
            JobPosDrop9.Visible = false;
            DeptDrop10.Visible = false;
            JobPosDrop10.Visible = false;
            MedDrop10.Visible = false;
            DeptDrop11.Visible = false;
            DietTypeDrop3.Visible = false;
            MemStatDrop11.Visible = false;
            UnitDrop12.Visible = false;
            HealthCondDrop12.Visible = false;
            HealthCondDrop13.Visible = false;
            UnitDrop9.Visible = false;
            EcoDrop19.Visible = false;
            SectDrop20.Visible = false;
            UnitDrop11.Visible = false;
            // HIDE FORM BUTTONS
            CreateBtn.Visible = false;
        }
        protected void ClearUpdateForm()
        {
            KeyBox.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            Label6.Visible = false;
            Label7.Visible = false;
            UpdateBox1.Visible = false;
            UpdateBox2.Visible = false;
            UpdateBox3.Visible = false;
            UpdateBox4.Visible = false;
            UpdateBox5.Visible = false;
            UpdateBox6.Visible = false;
            UpdateBox7.Visible = false;
            UpdateLbl.Visible = false;
            UpdateBtn.Visible = false;
        }
        protected void PopulateUpdateLabels()
        {
            String[] labels = new String[8];
            String table = GetTableName();
            String query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + table + "';";
            MySqlConnection conn = new MySqlConnection(ConnString);
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataReader reader = comm.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                labels[i] = reader.GetString(0);
                i++;
            }
            if (labels[1] != null) {
                Label1.Text = labels[1];
                Label1.Visible = true;
            }
            if (labels[2] != null) {
                Label2.Text = labels[2];
                Label2.Visible = true;
            }
            if (labels[3] != null) {
                Label3.Text = labels[3];
                Label3.Visible = true;
            }
            if (labels[4] != null) {
                Label4.Text = labels[4];
                Label4.Visible = true;
            }
            if (labels[5] != null) {
                Label5.Text = labels[5];
                Label5.Visible = true;
            }
            if (labels[6] != null) {
                Label6.Text = labels[6];
                Label6.Visible = true;
            }
            if (labels[7] != null) {
                Label7.Text = labels[7];
                Label7.Visible = true;
            }
        }
        protected string GetTableName()
        {
            String tableName = "";
            int index = QueryDropDown.SelectedIndex;
            switch (index)
            {
                case 1:
                    tableName = "animal";
                    return tableName;
                case 2:
                    tableName = "animal_handler";
                    return tableName;
                case 3:
                    tableName = "contact";
                    return tableName;
                case 4:
                    tableName = "diet";
                    return tableName;
                case 5:
                    tableName = "employee";
                    return tableName;
                case 6:
                    tableName = "enum_department";
                    return tableName;
                case 7:
                    tableName = "enum_diet_type";
                    return tableName;
                case 8:
                    tableName = "enum_ecosystem";
                    return tableName;
                case 9:
                    tableName = "enum_facility_status";
                    return tableName;
                case 10:
                    tableName = "enum_facility_type";
                    return tableName;
                case 11:
                    tableName = "enum_health_condition";
                    return tableName;
                case 12:
                    tableName = "enum_job_position";
                    return tableName;
                case 13:
                    tableName = "enum_medication";
                    return tableName;
                case 14:
                    tableName = "enum_membership_status";
                    return tableName;
                case 15:
                    tableName = "enum_membership_type";
                    return tableName;
                case 16:
                    tableName = "enum_section";
                    return tableName;
                case 17:
                    tableName = "enum_species";
                    return tableName;
                case 18:
                    tableName = "enum_state";
                    return tableName;
                case 19:
                    tableName = "enum_unit_measure";
                    return tableName;
                case 20:
                    tableName = "enum_work_order_type";
                    return tableName;
                case 21:
                    tableName = "exhibit";
                    return tableName;
                case 22:
                    tableName = "facility";
                    return tableName;
                case 23:
                    tableName = "health_profile";
                    return tableName;
                case 24:
                    tableName = "membership";
                    return tableName;
                case 25:
                    tableName = "prescription";
                    return tableName;
                case 26:
                    tableName = "user_login";
                    return tableName;
                case 27:
                    tableName = "work_order";
                    return tableName;
                default:
                    return tableName;
            }
        }
        protected int AddIndex(int dropIndex)
        {
            dropIndex++;
            return dropIndex;
        }
        protected void ShowFailureMessage()
        {
            ClearInsertForm();
            InsertDialog.Text = "Error: Query Unsuccessful. Check constraints.";
            InsertDialog.Visible = true;
        }
        protected void ReportsBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("GeneralReport.aspx");
        }

        protected void AnimalReportsBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnimalReport.aspx");
        }
        protected void AttemptTransaction(MySqlCommand cmd)
        {
            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                InsertDialog.Text = "Transaction Successful: " + rowsAffected + " rows affected.";
                InsertDialog.Visible = true;
            }
            catch
            {
                ShowFailureMessage();
            }
        }
    }
}
