using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Globalization;


namespace ZooApplication
{
    public partial class Handler : System.Web.UI.Page
    {
        string CONNECTION_STR = "server=cosc3380-02-team12.mysql.database.azure.com;" +
                                "uid=team12admin@cosc3380-02-team12;" +
                                "pwd=Team 12 is the very best team.;" +
                                "database=zoo" + ";convert zero datetime=True";



        protected void Page_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(CONNECTION_STR))
            {
                if (!IsPostBack)
                {
                    MySqlCommand DynamicList = new MySqlCommand("Select species_id, species_name FROM enum_species", conn);
                    conn.Open();
                    DropDownList1.DataSource = DynamicList.ExecuteReader();
                    DropDownList1.DataTextField = "species_name";
                    DropDownList1.DataValueField = "species_id";
                    DropDownList1.DataBind();
                    conn.Close();

                    DynamicList = new MySqlCommand("Select species_id, species_name FROM enum_species", conn);
                    conn.Open();
                    DropDownListAddSpecies.DataSource = DynamicList.ExecuteReader();
                    DropDownListAddSpecies.DataTextField = "species_name";
                    DropDownListAddSpecies.DataValueField = "species_id";
                    DropDownListAddSpecies.DataBind();
                    conn.Close();

                    DynamicList = new MySqlCommand("Select diet_type_id, diet_type_name FROM enum_diet_type", conn);
                    conn.Open();
                    DropDownListAddDiet.DataSource = DynamicList.ExecuteReader();
                    DropDownListAddDiet.DataTextField = "diet_type_name";
                    DropDownListAddDiet.DataValueField = "diet_type_id";
                    DropDownListAddDiet.DataBind();
                    conn.Close();



                    DynamicList = new MySqlCommand("Select exhibit_id, exhibit_name FROM exhibit", conn);
                    conn.Open();
                    DropDownListAddExhibit.DataSource = DynamicList.ExecuteReader();
                    DropDownListAddExhibit.DataTextField = "exhibit_name";
                    DropDownListAddExhibit.DataValueField = "exhibit_id";
                    DropDownListAddExhibit.DataBind();
                    conn.Close();
                }
            }



        }

        protected void AddAnimal(object sender, EventArgs e)
        {
            // CREATE HEALTH PROFILE
            MySqlConnection connection = new MySqlConnection(CONNECTION_STR);
            string health_profile_id = GenerateHealthProfileID();

            string Health_Profile_Insert = "INSERT INTO health_profile VALUES (" + health_profile_id + ", 'M', 0000-00-00, 0.0,'lb', 0.0, 'm',1)";

            connection.Open();

            MySqlCommand HealthProfileAddCommand = new MySqlCommand(Health_Profile_Insert, connection);

            HealthProfileAddCommand.ExecuteNonQuery();

            connection.Close();







            connection = new MySqlConnection(CONNECTION_STR);

            string animal_id = GenerateAnimalID();
            string animal_name = Add_Name.Text.Trim();
            string species = DropDownListAddSpecies.SelectedItem.Value;
            string diet = DropDownListAddDiet.SelectedItem.Value;
            string exhibit = DropDownListAddExhibit.SelectedItem.Value;
            string today = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();

            string Animal_Insert = "INSERT INTO animal VALUES (" + animal_id + ", '" + animal_name + "', " + species + ", " + health_profile_id + ", " +
                diet + ", " + exhibit + ", '" + today + "')";


            connection.Open();

            MySqlCommand AnimalAddCommand = new MySqlCommand(Animal_Insert, connection);

            AttemptTransaction(AnimalAddCommand);

            connection.Close();
        }

        protected void Show_All_Animals(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(CONNECTION_STR);

            string All_Animals = "SELECT * FROM animal";
            connection.Open();

            MySqlCommand ShowAnimals = new MySqlCommand(All_Animals, connection);

            MySqlDataReader reader = ShowAnimals.ExecuteReader();

            Grid_All_Animals.DataSource = reader;
            Grid_All_Animals.DataBind();

            connection.Close();


        }

        protected void AnimalByID(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(CONNECTION_STR);

            string animal_id = Animal_ID_Text.Text.Trim();

            string Animal_By_ID = "SELECT * FROM animal WHERE animal_id = '" + animal_id + "'";

            connection.Open();

            MySqlCommand ShowAnimalID = new MySqlCommand(Animal_By_ID, connection);



            MySqlDataReader reader = ShowAnimalID.ExecuteReader();

            Grid_Animal_ID.DataSource = reader;
            Grid_Animal_ID.DataBind();

            connection.Close();

        }

        protected void List_Species(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(CONNECTION_STR);

            string animal_species = DropDownList1.SelectedItem.Value;


            string Animal_By_Species = "SELECT * FROM animal WHERE species = '" + animal_species + "'";

            connection.Open();

            MySqlCommand ShowAnimalID = new MySqlCommand(Animal_By_Species, connection);



            MySqlDataReader reader = ShowAnimalID.ExecuteReader();

            Grid_Animal_Species.DataSource = reader;
            Grid_Animal_Species.DataBind();

            connection.Close();
        }
        protected void List_Exhibits(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(CONNECTION_STR);




            string Show_Exhibits = "SELECT * FROM exhibit";

            connection.Open();

            MySqlCommand Show_E = new MySqlCommand(Show_Exhibits, connection);



            MySqlDataReader reader = Show_E.ExecuteReader();

            Grid_Exhibits.DataSource = reader;
            Grid_Exhibits.DataBind();

            connection.Close();
        }
        protected void List_Diets(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(CONNECTION_STR);




            string Show_Diets = "SELECT * FROM diet";

            connection.Open();

            MySqlCommand Show_D = new MySqlCommand(Show_Diets, connection);



            MySqlDataReader reader = Show_D.ExecuteReader();

            Grid_Diets.DataSource = reader;
            Grid_Diets.DataBind();

            connection.Close();
        }



        //NEEDS ExecuteIDReader()
        protected String GenerateAnimalID()
        {
            String result;
            String query;

            query = "SELECT MAX(animal_id) FROM animal;";
            result = ExecuteIDReader(query);
            return result;
        }
        protected String GenerateDietID()
        {
            String result;
            String query;

            query = "SELECT MAX(diet_id) FROM diet;";
            result = ExecuteIDReader(query);
            return result;
        }
        protected String GenerateHealthProfileID()
        {
            String result;
            String query;

            query = "SELECT MAX(profile_id) FROM health_profile;";
            result = ExecuteIDReader(query);
            return result;
        }


        protected String ExecuteIDReader(String query)
        {
            String result = "error";
            int response = 0;
            MySqlConnection connection = new MySqlConnection(CONNECTION_STR);
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
        protected void ShowFailureMessage()
        {

            InsertDialog.Text = "Error: Query Unsuccessful. Check constraints.";
            InsertDialog.Visible = true;
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