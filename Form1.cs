using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDay1
{
    public partial class Form1 : Form
    {
        List<Course> courses = new List<Course>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string courseName = tbCourseName.Text;
            string courseId = tbCourseId.Text;
            string roomNumber = tbRoomNumber.Text;
            string student = tbStudent.Text;
            string teacher = tbTeacher.Text;

            Course c = new Course(courseName, courseId, roomNumber, student, teacher);

            courses.Add(c);
            
            
            
            
        }

        public void DisplayCourses(List<Course> courses)
        {
            
            foreach (Course course in courses)
            {
                string displayMessage = $"Course Name: {course.Name}" + $"\nCourse Id: {course.CourseId}" + $"\nRoom Number: {course.RoomNumber}" + $"\n Student: {course.Student}" + $"\nTeacher: {course.Teacher}";

                rtbDisplay.Text = displayMessage;
            }
        }
    }
}
