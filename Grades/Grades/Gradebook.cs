using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Gradebook
        //En klass funkar som en mall för att göra objekt. Det kan också användas för att göra en typ som används för en variabel.
    {
        public Gradebook()
            //Detta är en constructor, med den kan du bestämma vad ett objekt ska ha för standardvärden o.s.v.
        {
            grades = new List<float>();
            //När objektet "grades" tillkallas så skapas en nya lista som kan ta emot float värden.
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum = sum + grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void AddGrade(float grade)
        //Addgrade är en Method, float är typ och grade är en parameter.
        {
            grades.Add(grade);
        }
        //Allt inom brackets kallas "Scope"
        private List<float> grades;
        //Listan är en collection, som samlar float nummer. Fields "grades" är en variabel som deklarerats direkt i en class eller constructor.
    }
}
