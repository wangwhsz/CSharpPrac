using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrac1
{
    class Student
    {
        private string cName;
        private char cGender;
        private int nAge;
        private int nChineseScore;
        private int nMathScore;
        private int nEnglishScore;

        public string CName { get => cName; set => cName = value; }
        public char CGender { 
            get => cGender; 
            set { 
                if (value == '男' || value == '女')
                    cGender = value; 
                else { cGender = '空'; }
            } 
        }


        //cGender = value;
        public int NAge { get => nAge; set => nAge = value; }
        public int NChineseScore { get => nChineseScore; set => nChineseScore = value; }
        public int NMathScore { get => nMathScore; set => nMathScore = value; }
        public int NEnglishScore { get => nEnglishScore; set => nEnglishScore = value; }

        public void Greet()
        {
            Console.WriteLine("我叫{0}，今年{1}岁了，是{2}同学",cName,nAge,cGender);
        }
        public double CalcAveScore()
        {
            double nAveScore;
            nAveScore = (this.nChineseScore +
                        this.nMathScore +
                        this.nEnglishScore) / 3;
            return nAveScore;
        }
        public int CalcTotalScore()
        {
            return this.nChineseScore +
                   this.nMathScore +
                   this.nEnglishScore;
        }
        public void MyScore()
        {
            Console.WriteLine("我叫{0}，我的平均成绩是{1}，我的成绩总和是{2}",
                cName,
                CalcAveScore(),
                CalcTotalScore()
                );
        }
        public Student(string name,char gender,int age,int CScore,int MScore,int EScore)
        {
            this.CName = name;
            this.CGender = gender;
            this.NAge = age;
            this.NChineseScore = CScore;
            this.NMathScore = MScore;
            this.NEnglishScore = EScore;
        }
        public Student(string name, char gender, int age)
        {
            this.CName = name;
            this.CGender = gender;
            this.NAge = age;
        }
    }
}
