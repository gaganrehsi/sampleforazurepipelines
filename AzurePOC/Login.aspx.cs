using System;
using System.Data;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Server=HARIHARAN\\CLOUDPOC;Database=CloudUsers;Integrated Security=True");
        SqlCommand comm = new SqlCommand("select * from dbo.CloudUsers where userid='" + txtUserId.Text + "' and password='" + txtPassword.Text + "'", conn);
        conn.Open();
        object res = comm.ExecuteScalar();
        if (res != null)
        {
            lblResult.Text = "Hello World " + txtUserId.Text + " Logged in...";
        }
        else
        {
            lblResult.Text = "Hello World " + txtUserId.Text + " Not Logged in...";
        }
        conn.Close();
    }
}