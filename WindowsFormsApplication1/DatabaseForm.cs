using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    /*****************************************************************************************
                    * This is the connection string to the MySQL instance, you can use local host or
                    * the IP address of where the MySQL instance is located. the port then follows 
                    * (should almost always be 3306 for a local instance) then the username then the password
                    ******************************************************************************************/
                    string connection = "datasource=127.0.0.1;port=3306;username=root;password=";

                    /*****************************************************************************************
                    * This piece of code is what actually will connect to the database instance via the 
                    * connection string. The connection string will get passed to the new object.
                    ******************************************************************************************/
                    MySqlConnection sqlConnection = new MySqlConnection(connection);

                    /*****************************************************************************************
                    * The MySqlDataAdapter serves as a bridge between a DataSet and database for retrieving 
                    * and saving data. The MySqlDataAdapter provides this bridge by using Fill to load data 
                    * from the database into the DataSet, and using Update to send changes made in the DataSet 
                    * back to the database.
                    ******************************************************************************************/
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                    /****************************************************************************************
                    * The select command will start off like any other instead of using from, the name of the
                    * database . the name of the table in the database is used.
                    ******************************************************************************************/
                    dataAdapter.SelectCommand = new MySqlCommand("SELECT * pegasus.copier;", sqlConnection);

                    /*****************************************************************************************
                    * The MySqlDataAdapter can be assigned to the MySqlCommandBuilder. Once this happens, it 
                    * can generate any additional SQL statements that you do not set.
                    ******************************************************************************************/
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);

                    /****************************************************************************************
                    * This block opens the connection shows a message that we connected and then closes.
                    *****************************************************************************************/

                    MySqlCommand insert_DB = sqlConnection.CreateCommand();

                    insert_DB.CommandText = "INSERT INTO test.participants_table VALUES ('" + pid_tb.Text + "'," + "'" + firstName_tb.Text + "',"
                        + "'" + middleInitial_cb.Text + "'," + "'" + lastName_tb.Text + "'," + "'" + street_tb.Text + "'," + "'" + city_tb.Text + "'," 
                        + "'" + state_tb.Text + "'," + "'" + zip_tb.Text + "'," + "'" + male_rb.Text + "'," + "'" + dateTimePicker1.Text + "'," 
                        + "'" + emergencyName_tb.Text + "'," + "'" + emergencyPhone_tb.Text + "'," + "'" + yesMeds_rb.Text + "'," + "'" + yesSeizure_rb.Text + "' );";


                    Console.Out.WriteLine("INSERT INTO test.participants_table VALUES ('" + pid_tb.Text + "'," + "'" + firstName_tb.Text + "',"
                        + "'" + lastName_tb.Text + "'," + "'" + middleInitial_cb.Text + "'," + "'" + street_tb.Text + "'," + "'" + city_tb.Text + "'," 
                        + "'" + state_tb.Text + "'," + "'" + zip_tb.Text + "'," + "'" + male_rb.Text + "'," + "'" + dateTimePicker1.Text + "'," 
                        + "'" + emergencyPhone_tb.Text + "'," + "'" + emergencyName_tb.Text + "'," + "'" + yesMeds_rb.Text + "'," + "'" + yesSeizure_rb.Text + "' );");

                    sqlConnection.Open();
                    insert_DB.ExecuteNonQuery();
                    MessageBox.Show("Connected");
                    sqlConnection.Close();

                    // This will handle any errors/exceptions and let the user know that something went wrong
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured: " + ex.Message);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            city_tb.Text = "";
            emergencyName_tb.Text = "";
            emergencyPhone_tb.Text = "";
            firstName_tb.Text = "";
            lastName_tb.Text = "";
            pid_tb.Text = "";
            state_tb.Text = "";
            street_tb.Text = "";
            zip_tb.Text = "";
            middleInitial_cb.Text = "";
            
        }
    }
}

