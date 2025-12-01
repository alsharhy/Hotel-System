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


    public bool AddUser(string Username, string Password)
    {
        string cmdText = "INSERT INTO User_Table VALUES (@User_Name, @User_Password)";
        SqlConnection connection = GetConnection();
        SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Parameters.Add("@User_Name", SqlDbType.VarChar).Value = Username;
        sqlCommand.Parameters.Add("@User_Password", SqlDbType.VarChar).Value = Password;
        try
        {
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Added Successfully!", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        catch (SqlException ex)
        {
            if (ex.Number == 2627)
            {
                MessageBox.Show("Username already exist.", "Username", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "Add User", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            return false;
        }

        connection.Close();
        return true;
    }



    public void DisplayAndSearch(string query, DataGridView dgv)
    {
        SqlConnection connection = GetConnection();
        SqlCommand selectCommand = new SqlCommand(query, connection);
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
        DataTable dataTable = new DataTable();
        sqlDataAdapter.Fill(dataTable);
        dgv.DataSource = dataTable;
    }



    public bool UpdateUser(string ID, string Username, string Password)
    {
        string cmdText = "UPDATE User_Table SET User_Name = @UserName, User_Password = @UserPassword WHERE User_ID = @UserID";
        SqlConnection connection = GetConnection();
        SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = ID;
        sqlCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = Username;
        sqlCommand.Parameters.Add("@UserPassword", SqlDbType.VarChar).Value = Password;
        try
        {
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        catch (SqlException ex)
        {
            if (ex.Number == 2627)
            {
                MessageBox.Show("Username already exist.", "Username", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "Update User", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            return false;
        }

        connection.Close();
        return true;
    }





    public bool DeleteUser(string ID)
    {
        string cmdText = "DELETE FROM User_Table WHERE User_ID = @UserID";
        SqlConnection connection = GetConnection();
        SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = ID;
        try
        {
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully!", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error! \n" + ex.ToString(), "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return false;
        }

        connection.Close();
        return true;
    }







    public bool AddClient(string FirstName, string LastName, string Phone, string Address)
    {
        string cmdText = "INSERT INTO Client_Table VALUES (@Client_FirstName, @Client_LastName, @Client_Phone, @Client_Address)";
        SqlConnection connection = GetConnection();
        SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Parameters.Add("@Client_FirstName", SqlDbType.VarChar).Value = FirstName;
        sqlCommand.Parameters.Add("@Client_LastName", SqlDbType.VarChar).Value = LastName;
        sqlCommand.Parameters.Add("@Client_Phone", SqlDbType.VarChar).Value = Phone;
        sqlCommand.Parameters.Add("@Client_Address", SqlDbType.VarChar).Value = Address;
        try
        {
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Added Successfully!", "Client Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        catch (SqlException ex)
        {
            if (ex.Number == 2627)
            {
                MessageBox.Show("Phone No. already exist.", "Phone No.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            return false;
        }

        connection.Close();
        return true;
    }





    public bool UpdateClient(string ID, string FirstName, string LastName, string Phone, string Address)
    {
        string cmdText = "UPDATE Client_Table SET Client_FirstName = @ClientFirstName, Client_LastName = @ClientLastName, Client_Phone = @ClientPhone, Client_Address = @ClientAddress WHERE Client_ID = @ClientID";
        SqlConnection connection = GetConnection();
        SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Parameters.Add("@ClientID", SqlDbType.Int).Value = ID;
        sqlCommand.Parameters.Add("@ClientFirstName", SqlDbType.VarChar).Value = FirstName;
        sqlCommand.Parameters.Add("@ClientLastName", SqlDbType.VarChar).Value = LastName;
        sqlCommand.Parameters.Add("@ClientPhone", SqlDbType.VarChar).Value = Phone;
        sqlCommand.Parameters.Add("@ClientAddress", SqlDbType.VarChar).Value = Address;
        try
        {
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!", "Client Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        catch (SqlException ex)
        {
            if (ex.Number == 2627)
            {
                MessageBox.Show("Phone No. already exist.", "Phone No.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            return false;
        }

        connection.Close();
        return true;
    }



    public bool DeleteClient(string ID)
    {
        string cmdText = "DELETE FROM Client_Table WHERE Client_ID = @ClientID";
        SqlConnection connection = GetConnection();
        SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Parameters.Add("@ClientID", SqlDbType.Int).Value = ID;
        try
        {
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully!", "Client Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        catch (SqlException ex)
        {
            MessageBox.Show("Error! \n" + ex.ToString(), "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return false;
        }

        connection.Close();
        return true;
    }


}