using System;

namespace calc
{
    class calculation
    {
        public void prediction()
        {
            //1. complete population
            // in 5y: complete poulation until age 80y + agegroup -5 to -1
            int population5 = AgeGroup[3]+AgeGroup[4]+AgeGroup[5]+AgeGroup[6]+AgeGroup[7]+AgeGroup[8]+AgeGroup[9]+AgeGroup[10]+AgeGroup[11]+AgeGroup[12]+AgeGroup[13]+AgeGroup[14]+AgeGroup[15]+AgeGroup[16]+AgeGroup[17]+AgeGroup[18]+AgeGroup[19]+AgeGroup[20];
            int population10 = population5+AgeGroup[2]-AgeGroup[20];
            int population15 = population10+AgeGroup[1]-AgeGroup[19];
            int population20 = population15+AgeGroup[0]-AgeGroup[18];
            //2. prognosis for teachers
            //3. prognosis for children/students
            //4. prognosis infrastructure
        }
        public void calculator()
        {
            //1. needed teachers
            // amount of students divided by StudentsPerTeacher
            //2. needed schools
            // amount of students divided by StudentsPerSchool
        }
    }
}