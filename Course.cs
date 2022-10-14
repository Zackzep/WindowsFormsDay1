using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDay1
{
    //Always switch to public
    public class Course
    {
        //Fields
        string _name;
        string _courseId;
        string _roomNumber;
        string _teacher;
        string _student;

        public Course(string name, string courseId, string roomNumber, string teacher, string student)
        {
            _name = name;
            _courseId = courseId;
            _roomNumber = roomNumber;
            _teacher = teacher;
            _student = student;
        }

        public string Name { get => _name; set => _name = value; }
        public string CourseId { get => _courseId; set => _courseId = value; }
        public string RoomNumber { get => _roomNumber; set => _roomNumber = value; }
        public string Teacher { get => _teacher; set => _teacher = value; }
        public string Student { get => _student; set => _student = value; }
    }
}
