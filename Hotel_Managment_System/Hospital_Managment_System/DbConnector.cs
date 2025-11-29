using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//namespace DbConnector;

public class DbConnector
{
    private bool check = false;

    private SqlConnection GetConnection()
    {
        string connectionString = "Data Source = .\\SQLEXPRESS;\r\n    Initial Catalog = Hotel_Management_System;\r\n        Integrated Security = true";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        try
        {
            sqlConnection.Open();
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error! \n" + ex.ToString(), "SQL connection", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        return sqlConnection;
    }

    public bool IsValidNamePass(string Username, string Password)
    {
        try
        {
            string cmdText = "SELECT User_Name, User_Password FROM User_Table WHERE User_Name = '" + Username + "' AND User_Password = '" + Password + "'";
            SqlConnection connection = GetConnection();
            SqlCommand selectCommand = new SqlCommand(cmdText, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            connection.Close();
            if (dataTable.Rows.Count > 0)
            {
                check = true;
            }
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error! \n" + ex.ToString(), "Username and Password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        return check;
    }

}