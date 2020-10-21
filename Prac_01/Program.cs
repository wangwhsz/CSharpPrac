using CSharpPrac1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_01
{
    class Program
    {
        //public void StudentInit(string name,char gender,int age,int CScore,int MScore,int EScore,Student stu)
        //{
        //    stu.CName = name;
        //    stu.CGender = gender;
        //    stu.NAge = age;
        //    stu.NChineseScore = CScore;
        //    stu.NMathScore = MScore;
        //    stu.NEnglishScore = EScore;
        //}
        static void Main(string[] args)
        {
            Student stu1 = new Student("张三", '男', 18, 90, 95, 80);
            Student stu2 = new Student("小兰", '女', 16, 95, 85, 100);
            
            Program pr = new Program();
            //pr.StudentInit("张三",'男',18,90,95,80,stu1);
            //pr.StudentInit("小兰", '女', 16, 95, 85, 100, stu2);
            stu1.Greet();
            stu1.MyScore();
            stu2.Greet();
            stu2.MyScore();

        }
    }
}
