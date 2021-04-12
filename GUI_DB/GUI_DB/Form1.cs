using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace GUI_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cname = tbCourseName.Text;
            string ccode = tbCourseCode.Text;
            string connString = @"Server=WINDOWS-EKS4LMU\SQLEXPRESS;Database=Course;User Id=sa; Password=Talha1998;";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string query = string.Format("insert into courses values ('{0}','{1}')", cname, ccode);
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                int row_affected = cmd.ExecuteNonQuery();
                if (row_affected > 0)
                {
                    MessageBox.Show("Course Inserted");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<Course> courses = new List<Course>();
            string connString = @"Server=WINDOWS-EKS4LMU\SQLEXPRESS;Database=Course;User Id=sa; Password=Talha1998;";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string query = "select * from courses";
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Course c = new Course();
                    c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    c.CourseName = reader.GetString(reader.GetOrdinal("Course_Name"));
                    c.CourseCode = reader.GetString(reader.GetOrdinal("Course_Code"));
                    courses.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            dtCourses.DataSource = courses;
        }

        private void dtCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
