using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VideoRentalSystem
{
    public partial class Form1 : Form
    {
        //Starting new SQL Connection
        SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\OEM\\Desktop\\VideoRentalSystem\\database.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            
            //Loading database content from all tables
            showDbContent("Customer");
            showDbContent("Movie");
            showDbContent("Rental");
        }

        private void showDbContent(string tableName)
        {
            // Open SQL Connection
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(string.Format("SELECT * FROM {0}", tableName), sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            switch (tableName)
            {
            // Fill gridview with table content
                case "Customer":
                    customerDataGridView.DataSource = dataTable;
                    break;

                case "Movie":
                    movieGridView.DataSource = dataTable;
                    break;

                case "Rental":
                    rentalGridView.DataSource = dataTable;
                    break;
            }

            sqlConnection.Close();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
        // Open SQL Connection
            sqlConnection.Open();
            string query = "INSERT INTO Customer VALUES({0},'{1}','{2}','{3}','{4}');";

            try
            {
                int id = Int32.Parse(cID.Text);
                string fname = cfname.Text;
                string lname = clname.Text;
                string address = caddress.Text;
                string phone = cphone.Text;
                SqlCommand sqlCommand = new SqlCommand(string.Format(query, id, fname, lname, address, phone), sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Success! New customer added to Database");
            }
            catch (Exception err)
            {
                MessageBox.Show("Sorry! Please try again.\nError: " + e.ToString());
            }
            sqlConnection.Close();
            showDbContent("Customer");
        }


        //Method to delete customer
        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
        // Open SQL Connection
            sqlConnection.Open();
            string query = "DELETE FROM Customer WHERE customerID={0};";

            try
            {
                int id = Int32.Parse(cID.Text);
                SqlCommand sqlCommand = new SqlCommand(string.Format(query, id), sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Success! Customer has been removed from the database");
            }
            catch (Exception err)
            {
                MessageBox.Show("Sorry! Please try again.\nError: " + err.ToString());
            }
            sqlConnection.Close();
            showDbContent("Customer");
        }

        private void BtnAddMovie_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "INSERT INTO Movie VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}');";

            try
            {
                int id = Int32.Parse(mID.Text);
                string rating = mrating.Text;
                string title = mtitle.Text;
                string year = myear.Text;
                string cost = mcost.Text;
                string copies = mcopies.Text;
                string genre = mgenre.Text;
                SqlCommand sqlCommand = new SqlCommand(string.Format(query, id, rating, title, year, cost, copies, genre), sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Success! New Movie added to Database");

            }
            catch (Exception err)
            {
                MessageBox.Show("Sorry! Please try again.\nError: " + e.ToString());
            }

            sqlConnection.Close();
            showDbContent("Movie");
        }

        private void BtnDeleteMovie_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "DELETE FROM Movie WHERE movieID={0};";

            try
            {
                int id = Int32.Parse(mID.Text);
                SqlCommand sqlCommand = new SqlCommand(string.Format(query, id), sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Success! Movie has been removed from the database");
                showDbContent("Movie");
            }
            catch (Exception err)
            {
                MessageBox.Show("Sorry! Please try again.\nError: " + e.ToString());
            }
            sqlConnection.Close();
        }

        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "UPDATE Customer SET firstName='{0}', lastName='{1}', Address='{2}', Phone='{3}' WHERE customerID={4};";

            try
            {
                int id = Int32.Parse(cID.Text);
                string fname = cfname.Text;
                string lname = clname.Text;
                string address = caddress.Text;
                string phone = cphone.Text;
                SqlCommand sqlCommand = new SqlCommand(string.Format(query, fname, lname, address, phone, id), sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Success! Customer details updated.");

            }
            catch (Exception err)
            {
                MessageBox.Show("Sorry! Please try again.\nError: " + err.ToString());
            }

            sqlConnection.Close();
            showDbContent("Customer");
        }

        private void BtnUpdateMovie_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "UPDATE Movie SET Rating='{0}', Title='{1}', Year='{2}' Cost='{3}', Copies='{4}', Genre='{5}' WHERE customerID={6};";

            try
            {
                int id = Int32.Parse(mID.Text);
                string rating = mrating.Text;
                string title = mtitle.Text;
                string year = myear.Text;
                string cost = mcost.Text;
                string copies = mcopies.Text;
                string genre = mgenre.Text;
                SqlCommand sqlCommand = new SqlCommand(string.Format(query, rating, title, year, cost, copies, genre, id), sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Success! Movie details updated.");

            }
            catch (Exception err)
            {
                MessageBox.Show("Sorry! Please try again.\nError: " + e.ToString());
            }

            sqlConnection.Close();
            showDbContent("Movie");
        }
    
    
        //this method creates a new rental record
        private void BtnRent_Click(object sender, EventArgs e)
        {
        // Open SQL Connection
            sqlConnection.Open();


            try
            {
                string query = "INSERT INTO Rental VALUES({0},{1},{2},'{3}',{4});";

                int id = Int32.Parse(rentID.Text);
                int mid = Int32.Parse(rentmID.Text);
                int cid = Int32.Parse(rentcID.Text);

                DateTime dateTime = rentDate.Value;
                String date = dateTime.ToString("yyyy-MM-dd");

                query = string.Format(query, id, mid, cid, date, "NULL");
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            }
            catch (Exception err)
            {
                MessageBox.Show("Sorry! Please try again.\nError: " + e.ToString());
            }

            sqlConnection.Close();
            showDbContent("Rental");
        }
        //Saves the date of returning
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            string query = "UPDATE Rental SET dateReturned='{0}' WHERE rentID={1};";

            try
            {
                int id = Int32.Parse(returnID.Text);
                DateTime dateTime = rentDate.Value;
                String date = dateTime.ToString("yyyy-MM-dd");

                SqlCommand sqlCommand = new SqlCommand(string.Format(query, date, id), sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Success! Movie has been returned");

            }
            catch (Exception err)
            {
                MessageBox.Show("Sorry! Please try again.\nError: " + e.ToString());
            }

            sqlConnection.Close();
            showDbContent("Rental");
        }
        
       //These methods fetch the records with max occurences
        private void BtnMostCustomer_Click(object sender, EventArgs e)
        {
        // Open SQL Connection
            sqlConnection.Open();
            string query = "SELECT customerIDFK, COUNT(customerIDFK) AS value_occurence FROM Rental GROUP BY customerIDFK ORDER BY value_occurence DESC;";

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                MessageBox.Show("The customer who has rented most movies has customerID = " + dataTable.Rows[0][0].ToString());

            }
            catch (Exception err)
            {
                MessageBox.Show("Sorry! Please try again.\nError: " + err.ToString());
            }

            sqlConnection.Close();
        }

        private void BtnMostMovie_Click(object sender, EventArgs e)
        {
        // Open SQL Connection
            sqlConnection.Open();
            string query = "SELECT movieIDFK, COUNT(movieIDFK) AS value_occurence FROM Rental GROUP BY movieIDFK ORDER BY value_occurence DESC;";

            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                MessageBox.Show("The most rented movie has movieID = " + dataTable.Rows[0][0].ToString());

            }
            catch (Exception err)
            {
                MessageBox.Show("Sorry! Please try again.\nError: " + err.ToString());
            }

            sqlConnection.Close();
        }
    }
}
