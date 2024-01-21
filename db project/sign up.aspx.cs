using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using db_project.DAL;
namespace db_project
{
    
    public partial class sign_up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Plan(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "SELECT * from Memberships";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            GridView1.DataSource = reader;
            GridView1.DataBind();
            conn.Close();

            DropDownList1.Visible = true;
            string com = "Select * from Memberships";
            SqlDataAdapter adpt = new SqlDataAdapter(com, conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            DropDownList1.DataTextField = "PlanName";
            DropDownList1.DataValueField = "PlanID";
            DropDownList1.DataBind();
        }
        protected void Signup_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string email = Email.Text;
            string password1 = Password.Text;
            string password2 = ConfirmPassword.Text;
            if(password1!=password2)
            {
                s1.InnerHtml = Convert.ToString("Check password");
                return;
            }
            string firstname = FirstName.Text;
            string lastname = LastName.Text;
            string backup = BackupEmail.Text;
            string Phone = phone.Text;
            string c = card.Text;
            int plan = Convert.ToInt16(DropDownList1.SelectedValue);

            Class1 s = new Class1();
            s.SignUp(username, email, password1, firstname, lastname, backup, Phone, c,plan);
            s1.InnerHtml = Convert.ToString("done");
            newprofile(sender, e);

        }


        protected void newprofile(object sender, EventArgs e)
        {
            string email = Email.Text;

            string pname = TextBox3.Text;
            string password = TextBox4.Text;

            DataTable DT = new DataTable();

            Class1 objclass1 = new Class1();

            int status;
            status = objclass1.CreateProfile(email, pname, password, ref DT);

            if (status > 0)
            {
                div8.InnerHtml = Convert.ToString("done");

            }
            else
                div8.InnerHtml = Convert.ToString("You cannot create more profiles");
        }
    }
}