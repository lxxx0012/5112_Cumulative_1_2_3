using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using _5112_Cumulative_1_2_3.Models;

namespace _5112_Cumulative_1_2_3.Controllers
{
    public class TeachersDataController : ApiController
    {
        private SchoolDbContext school = new SchoolDbContext();


        [HttpGet]
        [Route("api/TeacherData/ListTeachers/{Searchfname?}")]

        public IEnumerable<Teacher> ListTeachers(String SearchKey = null)
        {

            //Create an instance connection
            MySqlConnection Conn = school.AccessDatabase();

            //Open the connection between Webserver and the database
            Conn.Open();

            //Establish a new command (query) for the database
            MySqlCommand cmd = Conn.CreateCommand();

            //SQL Query
            cmd.CommandText = "select * from teachers";
            cmd.Parameters.AddWithValue("@key", "%" + SearchKey + "%");
            cmd.Prepare();

            //Gather result set of query into a variable
            MySqlDataReader ResultSet = cmd.ExecuteReader();

            //Create an empty list of Teachers
            List<Teacher> Teachers = new List<Teacher> { };

            //Loop through each row the result set
            while (ResultSet.Read())
            {
                //Access column information by the database column as an index
                int Teacherid = Convert.ToInt32(ResultSet["teacherid"]);
                string Teacherfname = ResultSet["teacherfname"].ToString();
                string Teacherlname = ResultSet["teacherlname"].ToString();
                string Employeenumber = ResultSet["employeenumber"].ToString();
                DateTime Hiredate = Convert.ToDateTime(ResultSet["hiredate"]);
                Decimal Salary = Convert.ToDecimal(ResultSet["salary"]);

                Teacher NewTeacher = new Teacher();
                NewTeacher.Teacherid = Teacherid;
                NewTeacher.Teacherfname = Teacherfname;
                NewTeacher.Teacherlname = Teacherlname;
                NewTeacher.Employeenumber = Employeenumber;
                NewTeacher.Hiredate = Hiredate;
                NewTeacher.Salary = Salary;

                //Add the Teacher name to the list
                Teachers.Add(NewTeacher);
            }

            //Close teh connection between MySql and Webserver
            Conn.Close();

            //Return the final list of teacher name
            return Teachers;

        }

        [HttpGet]
        [Route("api/TeacherData/Teachersfname/{Searchfname?}")]

        public IEnumerable<Teacher> Teachersfname(String Searchfname = null)
        {

            //Create an instance connection
            MySqlConnection Conn = school.AccessDatabase();

            //Open the connection between Webserver and the database
            Conn.Open();

            //Establish a new command (query) for the database
            MySqlCommand cmd = Conn.CreateCommand();

            //SQL Query
            cmd.CommandText = "Select * from teachers where lower(teacherfname) like lower(@first)";
            cmd.Parameters.AddWithValue("@first", "%" + Searchfname + "%");
            cmd.Prepare();

            //Gather result set of query into a variable
            MySqlDataReader ResultSet = cmd.ExecuteReader();

            //Create an empty list of Teachers
            List<Teacher> Teachers = new List<Teacher> { };

            //Loop through each row the result set
            while (ResultSet.Read())
            {
                //Access column information by the database column as an index
                int Teacherid = Convert.ToInt32(ResultSet["teacherid"]);
                string Teacherfname = ResultSet["teacherfname"].ToString();
                string Teacherlname = ResultSet["teacherlname"].ToString();
                string Employeenumber = ResultSet["employeenumber"].ToString();
                DateTime Hiredate = Convert.ToDateTime(ResultSet["hiredate"]);
                Decimal Salary = Convert.ToDecimal(ResultSet["salary"]);

                Teacher NewTeacher = new Teacher();
                NewTeacher.Teacherid = Teacherid;
                NewTeacher.Teacherfname = Teacherfname;
                NewTeacher.Teacherlname = Teacherlname;
                NewTeacher.Employeenumber = Employeenumber;
                NewTeacher.Hiredate = Hiredate;
                NewTeacher.Salary = Salary;

                //Add the Teacher name to the list
                Teachers.Add(NewTeacher);
            }

            //Close teh connection between MySql and Webserver
            Conn.Close();

            //Return the final list of teacher name
            return Teachers;

        }

        //Search by last name

        [HttpGet]
        [Route("api/TeacherData/Teacherslname/{Searchlname?}")]

        public IEnumerable<Teacher> Teacherslname(String Searchlname = null)
        {

            //Create an instance connection
            MySqlConnection Conn = school.AccessDatabase();

            //Open the connection between Webserver and the database
            Conn.Open();

            //Establish a new command (query) for the database
            MySqlCommand cmd = Conn.CreateCommand();

            //SQL Query
            cmd.CommandText = "Select * from teachers where lower(teacherlname) like lower(@last)";
            cmd.Parameters.AddWithValue("@last", "%" + Searchlname + "%");
            cmd.Prepare();

            //Gather result set of query into a variable
            MySqlDataReader ResultSet = cmd.ExecuteReader();

            //Create an empty list of Teachers
            List<Teacher> Teachers = new List<Teacher> { };

            //Loop through each row the result set
            while (ResultSet.Read())
            {
                //Access column information by the database column as an index
                int Teacherid = Convert.ToInt32(ResultSet["teacherid"]);
                string Teacherfname = ResultSet["teacherfname"].ToString();
                string Teacherlname = ResultSet["teacherlname"].ToString();
                string Employeenumber = ResultSet["employeenumber"].ToString();
                DateTime Hiredate = Convert.ToDateTime(ResultSet["hiredate"]);
                Decimal Salary = Convert.ToDecimal(ResultSet["salary"]);

                Teacher NewTeacher = new Teacher();
                NewTeacher.Teacherid = Teacherid;
                NewTeacher.Teacherfname = Teacherfname;
                NewTeacher.Teacherlname = Teacherlname;
                NewTeacher.Employeenumber = Employeenumber;
                NewTeacher.Hiredate = Hiredate;
                NewTeacher.Salary = Salary;

                //Add the Teacher name to the list
                Teachers.Add(NewTeacher);
            }

            //Close teh connection between MySql and Webserver
            Conn.Close();

            //Return the final list of teacher name
            return Teachers;

        }
        // search by hiredate
        [HttpGet]
        [Route("api/TeacherData/TeachersHiredate/{Searchdate?}")]

        public IEnumerable<Teacher> TeachersHiredate(DateTime Searchdate )
        {

            //Create an instance connection
            MySqlConnection Conn = school.AccessDatabase();

            //Open the connection between Webserver and the database
            Conn.Open();

            //Establish a new command (query) for the database
            MySqlCommand cmd = Conn.CreateCommand();

            //SQL Query
            cmd.CommandText = "Select * from teachers where hiredate = @date";
            cmd.Parameters.AddWithValue("@date", "%" + Searchdate + "%");
            cmd.Prepare();

            //Gather result set of query into a variable
            MySqlDataReader ResultSet = cmd.ExecuteReader();

            //Create an empty list of Teachers
            List<Teacher> Teachers = new List<Teacher> { };

            //Loop through each row the result set
            while (ResultSet.Read())
            {
                //Access column information by the database column as an index
                int Teacherid = Convert.ToInt32(ResultSet["teacherid"]);
                string Teacherfname = ResultSet["teacherfname"].ToString();
                string Teacherlname = ResultSet["teacherlname"].ToString();
                string Employeenumber = ResultSet["employeenumber"].ToString();
                DateTime Hiredate = Convert.ToDateTime(ResultSet["hiredate"]);
                Decimal Salary = Convert.ToDecimal(ResultSet["salary"]);

                Teacher NewTeacher = new Teacher();
                NewTeacher.Teacherid = Teacherid;
                NewTeacher.Teacherfname = Teacherfname;
                NewTeacher.Teacherlname = Teacherlname;
                NewTeacher.Employeenumber = Employeenumber;
                NewTeacher.Hiredate = Hiredate;
                NewTeacher.Salary = Salary;

                //Add the Teacher name to the list
                Teachers.Add(NewTeacher);
            }

            //Close teh connection between MySql and Webserver
            Conn.Close();

            //Return the final list of teacher name
            return Teachers;

        }

        [HttpGet]
        [Route("api/TeacherData/TeachersSalary/{Searchsalary?}")]

        public IEnumerable<Teacher> TeachersSalary(String Searchsalary = null)
        {

            //Create an instance connection
            MySqlConnection Conn = school.AccessDatabase();

            //Open the connection between Webserver and the database
            Conn.Open();

            //Establish a new command (query) for the database
            MySqlCommand cmd = Conn.CreateCommand();

            //SQL Query
            cmd.CommandText = "Select * from teachers where salary = @salary";
            cmd.Parameters.AddWithValue("@salary", "%" + Searchsalary + "%");
            cmd.Prepare();

            //Gather result set of query into a variable
            MySqlDataReader ResultSet = cmd.ExecuteReader();

            //Create an empty list of Teachers
            List<Teacher> Teachers = new List<Teacher> { };

            //Loop through each row the result set
            while (ResultSet.Read())
            {
                //Access column information by the database column as an index
                int Teacherid = Convert.ToInt32(ResultSet["teacherid"]);
                string Teacherfname = ResultSet["teacherfname"].ToString();
                string Teacherlname = ResultSet["teacherlname"].ToString();
                string Employeenumber = ResultSet["employeenumber"].ToString();
                DateTime Hiredate = Convert.ToDateTime(ResultSet["hiredate"]);
                Decimal Salary = Convert.ToDecimal(ResultSet["salary"]);

                Teacher NewTeacher = new Teacher();
                NewTeacher.Teacherid = Teacherid;
                NewTeacher.Teacherfname = Teacherfname;
                NewTeacher.Teacherlname = Teacherlname;
                NewTeacher.Employeenumber = Employeenumber;
                NewTeacher.Hiredate = Hiredate;
                NewTeacher.Salary = Salary;

                //Add the Teacher name to the list
                Teachers.Add(NewTeacher);
            }

            //Close teh connection between MySql and Webserver
            Conn.Close();

            //Return the final list of teacher name
            return Teachers;

        }

        [HttpGet]
        [Route("api/TeacherData/FindTeacher/{id?}")]
        public Teacher FindTeacher(int id)
        {
            Teacher NewTeacher = new Teacher();
            //Create an instance connection
            MySqlConnection Conn = school.AccessDatabase();

            //Open the connection 
            Conn.Open();

            //Establish a new command (Query) for the database
            MySqlCommand cmd = Conn.CreateCommand();

            cmd.CommandText = "Select * from teachers where teacherid = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            //Gather result set of query into a variable
            MySqlDataReader ResultSet = cmd.ExecuteReader();

            while (ResultSet.Read())
            {
                int Teacherid = Convert.ToInt32(ResultSet["teacherid"]);
                string Teacherfname = ResultSet["teacherfname"].ToString();
                string Teacherlname = ResultSet["teacherlname"].ToString();
                string Employeenumber = ResultSet["employeenumber"].ToString();
                DateTime Hiredate = Convert.ToDateTime(ResultSet["hiredate"]);
                Decimal Salary = Convert.ToDecimal(ResultSet["salary"]);

                NewTeacher.Teacherid = Teacherid;
                NewTeacher.Teacherfname = Teacherfname;
                NewTeacher.Employeenumber = Employeenumber;
                NewTeacher.Hiredate = Hiredate;
                NewTeacher.Salary = Salary;

            }

            return NewTeacher;
        }
    }
}
