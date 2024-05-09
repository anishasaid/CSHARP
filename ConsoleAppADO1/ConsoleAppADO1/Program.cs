using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

// Configure Application with SqlServer Management Studio
// Establish connetion 

namespace ConsoleAppADO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Connection();
            Console.ReadLine();
        }

        static void Connection()
        {
            /* 1.
            string cs = "Data Source=DESKTOP-V0BTS6P\\SQLEXPRESS;Initial Catalog=ado_db;Integrated Security=true;";
            SqlConnection con = new SqlConnection(cs);

            con.Open();

            if(con.State == ConnectionState.Open)
            {
                Console.WriteLine("Connection has been created successfully.");
            }

            con.Close();
            */

            /*
            //2. with try-catch block
            string cs = "Data Source=DESKTOP-V0BTS6P\\SQLEXPRESS;Initial Catalog=ado_db;Integrated Security=true;";
            SqlConnection con = new SqlConnection(cs);

            try
            {
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connection has been created successfully.");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { 
                con.Close();
            }
            */

            /*
            //3. with - Using block{}
            string cs = "Data Source=DESKTOP-V0BTS6P\\SQLEXPRESS;Initial Catalog=ado_db;Integrated Security=true;";

            using (SqlConnection con = new SqlConnection(cs)) {
                con.Open();

                if(con.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connection has been exstablished successfully.");

                }

            }
            */

            
            //4. with - using and try-catch block

            //Use of SqlCommond Class - to fetch data from database into the Application

            string cs = "Data Source=DESKTOP-V0BTS6P\\SQLEXPRESS;Initial Catalog=ado_db;Integrated Security=true;";
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    if(con.State == ConnectionState.Open)
                    {
                        Console.WriteLine("Connection has been established successfully.");
                    }

                    string query = "select * from employee_tbl";
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataReader dr = cmd.ExecuteReader();
                    
                    while (dr.Read())
                    {
                        Console.WriteLine("Id: " + dr["id"] + ", Name: "+ dr["name"] + ", Gender: "+ dr["gender"]+ ", Age: "+ dr["age"]+ ", Salary: "+ dr["salary"]+ ", City: "+ dr["city"]);
                    }
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
            
            

            /*
             * In this case ConnetionString  cs is written in a "App.config" file
             * 
            string cs = ConfigurationManager.ConnetionStrings["dbsc"].ConnectionString;
            SqlConnection con = null;

            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    Console.WriteLine("connection estalblished successfully.");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

            */


        }
       
    }
}
