using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_结构的嵌套
{
    struct Student   //Student 结构
    {
        public struct Grade  //嵌套结构 (分数)
        {
            public string courseName;public double courseGrade;// 课程名称、分数
            public Grade(string name, double grade)
            {
                courseName = name;courseGrade = grade;
            }
        }
        public string studentID, studentName;//学号、姓名
        public Grade[] grades;//分数(嵌套结构类型)
        public Student(string id, string name)//学生结构的构造函数
        {
            studentID = id;studentName = name;grades = new Grade[3];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
