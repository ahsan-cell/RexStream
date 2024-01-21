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
    public partial class WebForm5 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["name"].ToString();
            //Session.Remove("name");
        }

        protected void Catlogue(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "SELECT ShowName from Shows";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            GridView1.DataSource = reader;
            GridView1.DataBind();
            conn.Close();

            conn.Open();
            string sql2 = "SELECT MovieName from Movies";
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            GridView4.DataSource = reader2;
            GridView4.DataBind();
            conn.Close();

        }
        protected void ShuffleMovie(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "select top 1 MovieName from Movies order by NEWID()";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            GridView2.DataSource = reader;
            GridView2.DataBind();
            conn.Close();
        }

        protected void ShuffleShow(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "select top 1 ShowName from Shows order by NEWID()";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            GridView3.DataSource = reader;
            GridView3.DataBind();
            conn.Close();
        }
        protected void smovie_click(object sender, EventArgs e)
        {
            string movie = SearchMovie.Text;

            DataTable DT = new DataTable();

            Class1 objclass1 = new Class1();

            int status;
            status = objclass1.SearchMovie(movie, ref DT);
            if (status > 0)
            {
                GridView5.DataSource = DT;
                GridView5.DataBind();
            }
            else
                first.InnerHtml = Convert.ToString("Movie not available");
        }


        protected void sshow_click(object sender, EventArgs e)
        {
            string show = SearchShow.Text;

            DataTable DT = new DataTable();

            Class1 objclass1 = new Class1();

            int status;
            status = objclass1.SearchShow(show, ref DT);
            if (status > 0)
            {
                GridView6.DataSource = DT;
                GridView6.DataBind();
            }
            else
                Div1.InnerHtml = Convert.ToString("Movie not available");
        }

        protected void CAST(object sender, EventArgs e)
        {
            f.InnerHtml = Convert.ToString("First Name");
            TextBox1.Visible = true;
            l.InnerHtml = Convert.ToString("Last Name");
            TextBox2.Visible = true;
            Button5.Visible = true;

        }

        protected void ssCast(object sender, EventArgs e)
        {
            string first = TextBox1.Text;
            string last = TextBox2.Text;

            string connStr = ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "select MovieName from Movies where MovieID in (select MovieID from [Cast] where CastID in (select ID from Actors where FirstName='"+first+"' and LastName='"+last+"'))";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            GridView8.DataSource = reader;
            GridView8.DataBind();
            conn.Close();



            conn.Open();
            string sql2 = "select ShowName from Shows where ShowID in (select ShowID from [Cast] where CastID in (select ID from Actors where FirstName='"+first+"' and LastName='"+last+"'))";
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            GridView7.DataSource = reader2;
            GridView7.DataBind();
            conn.Close();

        }

        protected void showall(object sender, EventArgs e)
        {
            f0.InnerHtml = Convert.ToString("Profile Name");
            TextBox3.Visible = true;
            l0.InnerHtml = Convert.ToString("Password");
            TextBox4.Visible = true;
            Button8.Visible = true;
            
        }

        protected void newprofile(object sender, EventArgs e)
        {
            string email = Session["email"].ToString();

            string pname = TextBox3.Text;
            string password = TextBox4.Text;

            DataTable DT = new DataTable();

            Class1 objclass1 = new Class1();

            int status;
            status = objclass1.CreateProfile(email, pname, password, ref DT);

            if (status > 0)
            {
                div8.InnerHtml = Convert.ToString("Profile Created");

            }
            else
                div8.InnerHtml = Convert.ToString("You cannot create more profiles");
        }


        protected void showgenre1(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            DropDownList1.Visible = true;
            Button10.Visible = true;
            string com = "Select * from Genres";
            SqlDataAdapter adpt = new SqlDataAdapter(com, conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            DropDownList1.DataTextField = "GenreName";
            DropDownList1.DataValueField = "GenreName";
            DropDownList1.DataBind();
            conn.Close();

           
        }

        protected void showgenre2(object sender, EventArgs e)
        {
            //string genre = Convert.ToString(DropDownList1.SelectedValue);

            //DataTable DT = new DataTable();

            //Class1 objclass1 = new Class1();
            //objclass1.SearchShowgenre(genre, ref DT);
            //GridView9.DataSource = DT;
            //GridView9.DataBind();


            string show = Convert.ToString(DropDownList1.SelectedValue);

            string connStr = ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "select ShowName from Shows s join shows_moives_genres smg on s.ShowID = smg.ShowID inner join Genres g on g.GenreID = smg.GenreID where g.GenreName='"+show+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            GridView9.DataSource = reader;
            GridView9.DataBind();
            conn.Close();
        }


        protected void moviegenre1(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            DropDownList2.Visible = true;
            Button12.Visible = true;
            string com = "Select * from Genres";
            SqlDataAdapter adpt = new SqlDataAdapter(com, conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DropDownList2.DataSource = dt;
            DropDownList2.DataBind();
            DropDownList2.DataTextField = "GenreName";
            DropDownList2.DataValueField = "GenreName";
            DropDownList2.DataBind();
            conn.Close();


        }


        protected void moviegenre2(object sender, EventArgs e)
        {
            //string genre = Convert.ToString(DropDownList1.SelectedValue);

            //DataTable DT = new DataTable();

            //Class1 objclass1 = new Class1();
            //objclass1.SearchShowgenre(genre, ref DT);
            //GridView9.DataSource = DT;
            //GridView9.DataBind();


            string show = Convert.ToString(DropDownList2.SelectedValue);

            string connStr = ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "select MovieName from Movies s join shows_moives_genres smg on s.MovieID = smg.MovieID inner join Genres g on g.GenreID = smg.GenreID where g.GenreName='" + show + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            GridView10.DataSource = reader;
            GridView10.DataBind();
            conn.Close();
        }
    }
}