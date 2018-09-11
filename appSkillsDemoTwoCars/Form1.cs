using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace appSkillsDemoTwoCars
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection;

        public Form1()
        {
            connection = new OleDbConnection(@"Provider= Microsoft.ACE.OLEDB.15.0; Data Source= "
                       + Application.StartupPath + "/GUI/skillsDemo2CarDatabase.accdb");
            InitializeComponent();
        }

        //button to show connection
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider= Microsoft.ACE.OLEDB.12.0;Data Source=P:\GUI\skillsDemo2CarDatabase.accdb";
                connection.Open();
                LblConnect.Text = "Connected";
                connection.Close();
            }
            //exception message for errors
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }

        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            //displaying the database in the list box
            LstCars.Items.Clear();

            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command;
            OleDbDataReader dataReader;
            string sql;

            //open the connection
            connection.ConnectionString = @"Provider= Microsoft.ACE.OLEDB.12.0; Data Source= " 
                                        + Application.StartupPath + "/skillsDemo2CarDatabase.accdb";
            connection.Open();

            //Configure the SQL query
            sql = "Select * from Cars";

            //Create the command object to use the connection with the sql query
            command = new OleDbCommand(sql, connection);

            //Execute the SELECT command returning a data Reader
            dataReader = command.ExecuteReader();

            //Display the deatils of table in a list box
            while (dataReader.Read())
            {
                LstCars.Items.Add("Order number: " + " " + dataReader.GetValue(0).ToString());
                LstCars.Items.Add("Car Make: " + " " + dataReader.GetValue(1).ToString());
                LstCars.Items.Add("Model: " + " " + dataReader.GetValue(2).ToString());
                LstCars.Items.Add("Colour: " + " " + dataReader.GetValue(3).ToString());
                LstCars.Items.Add("Petrol: " + " " + dataReader.GetValue(4).ToString());
                LstCars.Items.Add("Engine Size: " + " " + dataReader.GetValue(5).ToString());
                LstCars.Items.Add(" "); 
            }

            
            
        }

        private void BtnAddCar_Click(object sender, EventArgs e)
        {

            //open the connection
            connection.ConnectionString = @"Provider= Microsoft.ACE.OLEDB.12.0; Data Source= "
                                        + Application.StartupPath + "/skillsDemo2CarDatabase.accdb";
            connection.Open();

            //declaring variables
            String OrderNumber = "";
            String CarManufacturer = "";
            String Model = "";
            String Colour = "";
            Boolean Petrol;
            Double EngineSize = 0.0;

            OleDbCommand command;
            string sql;

            //assigning variables
            OrderNumber = TxtOrderNumber.Text;
            CarManufacturer = TxtCarManufacturer.Text;
            Model = TxtModel.Text;
            Colour = TxtColour.Text;
            Petrol = ChkPetrol.Checked;
            EngineSize = double.Parse(TxtEngineSize.Text);

            sql = "INSERT INTO Cars(OrderNumber, CarManufacturer, Model, Colour, Petrol, EngineSize)" +
                  "VALUES (@OrderNumber, @CarManufacturer, @Model, @Colour, @Petrol, @EngineSize)";

            //Configure the command to use the connection with the sql query
            command = new OleDbCommand(sql, connection);
            command.Parameters.AddWithValue("@OrderNumber", OrderNumber);
            command.Parameters.AddWithValue("@CarManufacturer", CarManufacturer);
            command.Parameters.AddWithValue("@Model", Model);
            command.Parameters.AddWithValue("@Clour", Colour);
            command.Parameters.AddWithValue("@Petrol", Petrol);
            command.Parameters.AddWithValue("@EngineSize", EngineSize);


            //execute the insert command
            command.ExecuteNonQuery();

            //Close the connectio     

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command;
            string ordernumber;
            string sql;

            ordernumber = TxtOrderNumber.Text;

            //open the connection
            connection.ConnectionString = @"Provider= Microsoft.ACE.OLEDB.12.0; Data Source= "
                                        + Application.StartupPath + "/skillsDemo2CarDatabase.accdb";
            connection.Open();

            //Configure the SQL query
            sql = "DELETE FROM Cars WHERE OrderNumber = @ordernumber";

            command = new OleDbCommand(sql, connection);
            command.Parameters.AddWithValue("@OrderNumber", ordernumber);

            command.ExecuteNonQuery();
        }

        //application exit button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //update button
        private void BtnAmend_Click(object sender, EventArgs e)
        {
            //declaring variables
            OleDbConnection connection = new OleDbConnection();
            OleDbCommand command;
            string sql;
            string Model;
            string Colour;
            string CarManufacturer;
            string OrderNumber;
            double EngineSize;
            Boolean Petrol;

            //open the connection
            connection.ConnectionString = @"Provider= Microsoft.ACE.OLEDB.12.0; Data Source= "
                                        + Application.StartupPath + "/skillsDemo2CarDatabase.accdb";
            connection.Open();

            //assigning the declarations
            Model = TxtModel.Text;
            Colour = TxtColour.Text;
            CarManufacturer = TxtCarManufacturer.Text;
            OrderNumber = TxtOrderNumber.Text;
            Petrol = ChkPetrol.Checked;
            EngineSize = double.Parse(TxtEngineSize.Text);

            //sql statement
            sql = "UPDATE Cars SET CarManufacturer=@CarManufacturer, Model=@Model, Colour=@Colour, Petrol=@Petrol, EngineSize=@EngineSize WHERE OrderNumber=@OrderNumber";

            //configure the command to use the connection with the sql query
            command = new OleDbCommand(sql, connection);
            command.Parameters.AddWithValue("@CarManufacturer", CarManufacturer);
            command.Parameters.AddWithValue("@Model", Model);
            command.Parameters.AddWithValue("@Colour", Colour);
            command.Parameters.AddWithValue("@Petrol", Petrol);
            command.Parameters.AddWithValue("@EngineSize", EngineSize);
            command.Parameters.AddWithValue("@OrderNumber", OrderNumber);
            
            //execute the update command
            command.ExecuteNonQuery();

            //close the connection
            connection.Close();
        }

        //help button
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                 ("\t\tDatabase help:\n\n" +
                 "This database can SHOW records, ADD records, DELETE records and UPDATE records\n\n" +
                 "\t\tShowing a record:\n\n" +
                 "To show the records curently in the database, click the \"SHOW DATABASE\" button\n\n" +
                 "\t\tAdding a record:\n\n" +
                 "If you wish to add another record, you must add in all of the details of the new car in the appropriate fields and click the \"ADD RECORD\" button\n\n" +
                 "\t\tDeleting a record:\n\n" +
                 "If you wish to delete a record, simply choose the Order Number of the record you wish to delete, enter that order number into the Order number field and click the \"DELETE\" button\n\n" +
                 "\t\tUpdating a record:\n\n" +
                 "If you wish to update a record you can enter the Order number of the record you wish to update. Then you can enter in the new details of the record and click the \"UPDATE\" button\n\n" +
                 "\t\tHow to exit the program:\n\n" +
                 "Click on the white \"EXIT\" button in the bottom right hand corner.",
                 "Help",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
        }
    }
}
