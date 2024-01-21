using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using db_project.DAL;


namespace db_project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login_Button_Click(object sender, EventArgs e)
        {
            String email = Username.Text;
            String password = Password.Text;

            Session["email"] = email;

            DataTable DT = new DataTable();

            Class1 objclass1 = new Class1();

            int status;
            status = objclass1.LogIn(email, password, ref DT);

            if(status>0)
            {
                GridView1.DataSource = DT;
                GridView1.DataBind();
                message.InnerHtml = Convert.ToString("Following Items Found");
                p.InnerHtml= Convert.ToString("Choose a profile name:");
                //pid.Visible = true;
                DropDownList1.Visible = true;
                string str = "Data Source=BAT-COMPUTER\\SQLEXPRESS; Initial Catalog=RexStream; User ID=sa; password=123456";
                SqlConnection con = new SqlConnection(str);
                string com = "Select * from Profiles join Accounts on Profiles.UserID=Accounts.UserID where email='"+Username.Text+"'";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
                DropDownList1.DataTextField = "ProfileName";
                DropDownList1.DataValueField = "ProfileName";
                DropDownList1.DataBind();
                p2.InnerHtml = Convert.ToString("Enter profile password");
                Password2.Visible = true;
                Button2.Visible = true;
            }
            else
            {
                message.InnerHtml = Convert.ToString("Account Not Found");
                GridView1.DataSource = null;
                GridView1.DataBind();
            }

        }

        protected void Plogin_button(object sender, EventArgs e)
        {
            string pname =Convert.ToString(DropDownList1.SelectedValue);
           
            string pass = Password2.Text;

            DataTable DT = new DataTable();

            Class1 objclass1 = new Class1();

            int status;
            status = objclass1.PLogIn(pname, pass, ref DT);

            if(status>0)
            {
               // GridView2.Visible = true;
               // GridView3.Visible = false;
                string username = Username.Text;
             
                
                DataTable DT2 = new DataTable();
                objclass1.ContinueWatchingshows(username, pname,ref DT2);
                GridView2.DataSource = DT2;
                GridView2.DataBind();


                DataTable DT3 = new DataTable();
                objclass1.ContinueWatchingmovies(username, pname, ref DT3);
                GridView3.DataSource = DT3;
                GridView3.DataBind();

                Button3.Visible = true;

                
                Session["name"] = pname;
                Session["ProfileId"] = DropDownList1.DataValueField;
                //Server.Transfer("WebForm5.aspx");
            }
            else
            {
                message.InnerHtml = Convert.ToString("Done dona done done");
            }
        }
    }
}