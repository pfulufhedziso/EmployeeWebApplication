using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeWebApplication
{
    public partial class EditData : Page
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
            SqlCommand sqlCommand = new SqlCommand("Select * from Employee",sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();

        }
        // this method is used to delete records from the database
        private void Delete()
        {
            sqlConnection.Open();
            string query = "DELETE Employee WHERE EmployeeCode = '" + EmployeeCodetxt.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCodetxt.Text);

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Data was successfully deleted');", true);

            DisplayData();

        }
        // this method is used to update records from the database
        private void Update()
        {
            sqlConnection.Open();

          
            string query = "UPDATE  Employee SET Name=@Name,Surname=@Surname,DOB=@DOB,EmployeeStatus=@EmployeeStatus WHERE EmployeeCode = '" +EmployeeCodetxt.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCodetxt.Text);
            sqlCommand.Parameters.AddWithValue("@Name", NameTxtbox.Text);
            sqlCommand.Parameters.AddWithValue("@Surname", Surnametxtbox.Text);
            sqlCommand.Parameters.AddWithValue("@DOB", DOBtxtBox.Text);
            sqlCommand.Parameters.AddWithValue("@EmployeeStatus", EmployeeStatus.SelectedValue);

            sqlCommand.ExecuteNonQuery();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update was successfully ');", true);

            sqlConnection.Close();
            EmployeeCodetxt.Text = "";
            NameTxtbox.Text = "";
            Surnametxtbox.Text = "";
            DOBtxtBox.Text = "";
            EmployeeStatus.Text = "";
            DisplayData();

        }

        protected void UPdatebtn_Click(object sender, EventArgs e)
        {
            Update();
        }

        protected void Deletebtn_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}