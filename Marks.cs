using System;

namespace AbstractClassWork
{
    public abstract class Marks
    {
        public abstract double getPercentage();
    }
    public class fristPerson : Marks
    {
         public double sum=0;
         public double SubjectA;
         public double SubjectB;
         public double SubjectC;
        public fristPerson(double subjectA, double subjectB,double subjectC)
        {
           SubjectA=subjectA;
           SubjectB=subjectB;
           SubjectC=subjectC;
        }

        public override double getPercentage()
        {
           sum=SubjectA+SubjectB+SubjectC;
           double percent=sum*100/300;
           return percent;
        }
    }
      public class secondPerson : Marks
    {
        public double summm=0;
         public double w;
         public double x;
         public double y;
         public double z;
           public secondPerson(double subjectA, double subjectB,double subjectC, double subjectD)
        {
           w=subjectA;
           x=subjectB;
           y=subjectC;
           z=subjectD;
        }

        public override double getPercentage()
        {
          summm=w+x+y+z;
           double percent=summm*100/400;
           return percent;
        }
    }

}
