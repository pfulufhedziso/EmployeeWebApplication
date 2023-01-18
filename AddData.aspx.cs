using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EmployeeWebApplication
{
    public partial class AddData : Page
    {
        // making this a global so  that it can be acessed from any method
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-07GSTEC8\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayData();
            }

        }
        // this method is used to display data on a gridview
        private void DisplayData()
        {

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from Employee", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();

        }
        // method to upload data into database
        private void UploadData()
        {
            sqlConnection.Open();

            // query to insert data into the employee table
            string query = "INSERT INTO Employee(Name,Surname,DOB,EmployeeStatus)values(@Name,@Surname,@DOB,@EmployeeStatus)";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Name", NameTxtbox.Text);
            sqlCommand.Parameters.AddWithValue("@Surname", Surnametxtbox.Text);
            sqlCommand.Parameters.AddWithValue("@DOB", DOBtxtBox.Text);
            sqlCommand.Parameters.AddWithValue("@EmployeeStatus", EmployeeStatus.SelectedValue);

            sqlCommand.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Data was successfully inserted');",true);
            
            sqlConnection.Close();

            NameTxtbox.Text = "";
            Surnametxtbox.Text = "";
            DOBtxtBox.Text = "";
            EmployeeStatus.Text = "";
        }
        // method to clear all txt boxes
        private void ClearTxtBox()
        {
            NameTxtbox.Text = "";
            Surnametxtbox.Text = "";
            DOBtxtBox.Text = "";
            EmployeeStatus.Text = "";
        }

       

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            UploadData();
            DisplayData();
        }

        protected void Clearbtn_Click(object sender, EventArgs e)
        {
            ClearTxtBox();
        }
    }
}