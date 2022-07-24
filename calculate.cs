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
            int populationwork = population5-AgeGroup[3]-AgeGroup[4]-AgeGroup[5]-AgeGroup[6]-AgeGroup[7]+AgeGroup[21];
            int populationwork5 = populationwork+Agegroup[7]-AgeGroup[20];
            int populationwork10 = populationwork5+AgeGroup[6]-Agegroup[19];
            int populationwork15 = populationwork10+AgeGroup[5]-Agegroup[18];
            int populationwork20 = populationwork15+AgeGroup[4]-Agegroup[17];
            //2. prognosis for teachers
            // amountTeachers / totalWorkingPopulation
            float teacherrate = 5 /populationwork;
            float teachers5 = teacherrate / populationwork5 ;
            float teachers10 = teacherrate / populationwork10;
            float teachers15 = teacherrate / populationwork15;
            float teachers20 = teacherrate / populationwork20;
            //3. prognosis for children/students
            int students5 = AgeGroup[5]+AgeGroup[6]+AgeGroup[7];
            int students10 = AgeGroup[5]+AgeGroup[6]+AgeGroup[4];
            int students15 = AgeGroup[5]+AgeGroup[3]+AgeGroup[4];
            int students20 = AgeGroup[2]+AgeGroup[3]+AgeGroup[4];
            //4. prognosis infrastructure
            int schools = NumberBuildings1;
        }
        public void calculator()
        {
            //1. needed teachers
            // amount of students divided by StudentsPerTeacher
            //optimal StudentsPerTeacher by 20
            double teachersneeded5 = students5 / 20;
            double teachersneeded10 = students10 / 20;
            double teachersneeded15 = students15 / 20;
            double teachersneeded20 = students20 / 20;
            //2. needed schools
            // amount of students divided by StudentsPerSchool
            double schoolsneeded5 = students5 / AverageCapacity1;
            double schoolsneeded10 = students10 / AverageCapacity1;
            double schoolsneeded15 = students15 / AverageCapacity1;
            double schoolsneeded20 = students20 / AverageCapacity1;
        }
    }
}
