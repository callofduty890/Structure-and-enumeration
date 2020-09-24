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
                courseName = name;courseGrade = grade;//课程名称、课程分数
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
            Student s1 = new Student("202092401", "张三");
            s1.grades = new Student.Grade[] { new Student.Grade("语文",80),
                                                                    new Student.Grade("英语",100)};
            Console.WriteLine("Student ID={0},Student Name={1}", s1.studentID, s1.studentName);
            //遍历显示成绩
            foreach (Student.Grade item in s1.grades)
            {
                Console.WriteLine("Course={0},Grade={1}", item.courseName, item.courseGrade);
            }
            Console.ReadKey();
        }
    }
}
