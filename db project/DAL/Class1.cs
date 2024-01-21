using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace db_project.DAL
{
    public class Class1
    {
        private static readonly string connString =
           System.Configuration.ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
        

        public DataSet SelectItem() //to get the values of all the items from table Items and return the Dataset
        {

            DataSet ds = new DataSet(); //declare and instantiate new dataset
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Select * from Movies", con);  //instantiate SQL command 
                cmd.CommandType = CommandType.Text; //set type of sqL Command
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds); //Add the result  set  returned from SQLCommand to ds
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

            return ds; //return the dataset
        }

        public int LogIn(String email,string password, ref DataTable DT)
        {

            int status = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Sign_in ", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@email", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pass", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters["@pass"].Value = password;

                cmd.ExecuteNonQuery();

                // read output value 
                status = Convert.ToInt32(cmd.Parameters["@status"].Value); //convert to output parameter to interger format

                if (status == 1)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                    {
                        da.Fill(ds);

                    }

                    DT = ds.Tables[0];

                }


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return status;

        }



        public int PLogIn(String ProfileName, string password, ref DataTable DT)
        {

            int status = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("profilein ", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@pname", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pass", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@pname"].Value = ProfileName;
                cmd.Parameters["@pass"].Value = password;

                cmd.ExecuteNonQuery();

                // read output value 
                status = Convert.ToInt32(cmd.Parameters["@status"].Value); //convert to output parameter to interger format

                if (status == 1)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                    {
                        da.Fill(ds);

                    }

                    DT = ds.Tables[0];

                }


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return status;

        }




        public void SignUp(String username, string email,string password,string firstname,string lastname,string backup,string phone,string card,int plan)
        {

          
            //DataSet ds2 = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("signup ", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Username", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@Firstname", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@Lastname", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@backup", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@phone", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@card", SqlDbType.VarChar,20);
                cmd.Parameters.Add("@plan", SqlDbType.Int);

                // set parameter values
                cmd.Parameters["@Username"].Value = username;
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters["@password"].Value = password;
                cmd.Parameters["@Firstname"].Value = firstname;
                cmd.Parameters["@Lastname"].Value = lastname;
                cmd.Parameters["@backup"].Value = backup;
                cmd.Parameters["@phone"].Value = phone;
                cmd.Parameters["@card"].Value = card;
                cmd.Parameters["@plan"].Value = plan;


                cmd.ExecuteNonQuery();

                con.Close();


            }
            catch (SqlException ex)
            {
                
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            

        }

        public void ContinueWatchingshows(String username, string pname, ref DataTable DT)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            DataSet ds = new DataSet();
            try
            {
                cmd = new SqlCommand("checkcontinueshows ", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pname", SqlDbType.VarChar, 20);


                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@pname"].Value = pname;
                cmd.ExecuteNonQuery();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                {
                    da.Fill(ds);

                }

                DT = ds.Tables[0];

                con.Close();
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void ContinueWatchingmovies(String username, string pname, ref DataTable DT)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            DataSet ds = new DataSet();
            try
            {
                cmd = new SqlCommand("checkcontinuemovies ", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@username", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pname", SqlDbType.VarChar, 20);


                cmd.Parameters["@username"].Value = username;
                cmd.Parameters["@pname"].Value = pname;
                cmd.ExecuteNonQuery();


                using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                {
                    da.Fill(ds);

                }

                DT = ds.Tables[0];

                con.Close();
            }

            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        public int SearchMovie(String movie, ref DataTable DT)
        {

            int status = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("searchMovie ", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@movie", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@movie"].Value = movie;
                

                cmd.ExecuteNonQuery();

                // read output value 
                status = Convert.ToInt32(cmd.Parameters["@status"].Value); //convert to output parameter to interger format

                if (status == 1)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                    {
                        da.Fill(ds);

                    }

                    DT = ds.Tables[0];

                }


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return status;

        }



        public int SearchShow(String show, ref DataTable DT)
        {

            int status = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("searchShow ", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@show", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@show"].Value = show;


                cmd.ExecuteNonQuery();

                // read output value 
                status = Convert.ToInt32(cmd.Parameters["@status"].Value); //convert to output parameter to interger format

                if (status == 1)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                    {
                        da.Fill(ds);

                    }

                    DT = ds.Tables[0];

                }


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return status;

        }

        public int CreateProfile(String Email, string ProfileName,string password ,ref DataTable DT)
        {

            int status = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("createProfile ", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@uemail", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@pname", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 20);
                cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@uemail"].Value = Email;
                cmd.Parameters["@pname"].Value = ProfileName;
                cmd.Parameters["@password"].Value = password;

                cmd.ExecuteNonQuery();

                // read output value 
                status = Convert.ToInt32(cmd.Parameters["@status"].Value); //convert to output parameter to interger format

                //if (status == 1)
                //{
                //    using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                //    {
                //        da.Fill(ds);

                //    }

                //    DT = ds.Tables[0];

                //}


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return status;

        }


        
    }
}