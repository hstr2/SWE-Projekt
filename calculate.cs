using System;

namespace calc
{
    class calculation
    {   
        int population5 = 0;
        int population10 = 0;
        int population15 = 0;
        int population20 = 0;
        public void prediction(DataCoordinator lists)
        //e.g. intervall = 5, number = 4: 4 predictions in intervall of 5 years -> in 5, 10, 15, 29 years
        {
            //1. complete population
            // in 5y: complete poulation until age 80y + agegroup -5 to -1
        
            var selectedList = from age in lists.AgeGroups
                               where age.Youngest >= -5 && age.Oldest<= 80 //life-expectation at 85 years
                               select age;
            foreach (var age in selectedList)
                population5 +=  age.Number;             

            // oder 
                //foreach (var agegroup in lists.AgeGroups)
                //    {
                //        if (agegroup.Youngest >= -5 && agegroup.Oldest<=80)
                //        {
                //            population5 += agegroup.Number;
                //        }
                //        else {break;}
                //    }        


            selectedList =  from age in lists.AgeGroups
                            where age.Youngest >= -10 && age.Oldest<= 75 
                            select age;
            foreach (var age in selectedList)
                population10 +=  age.Number;  



            selectedList =  from age in lists.AgeGroups
                            where age.Youngest >= -15 && age.Oldest<= 70 
                            select age;
            foreach (var age in selectedList)
                population15 +=  age.Number; 
            


            selectedList =  from age in lists.AgeGroups
                            where age.Youngest >= -20 && age.Oldest<= 65 
                            select age;
            foreach (var age in selectedList)
                population20 +=  age.Number; 



            int populationwork = population5-AgeGroup[3]-AgeGroup[4]-AgeGroup[5]-AgeGroup[6]-AgeGroup[7]+AgeGroup[21];
            int populationwork5 = populationwork+Agegroup[7]-AgeGroup[20];
            int populationwork10 = populationwork5+AgeGroup[6]-Agegroup[19];
            int populationwork15 = populationwork10+AgeGroup[5]-Agegroup[18];
            int populationwork20 = populationwork15+AgeGroup[4]-Agegroup[17];


            //2. prognosis for teachers
            // amountTeachers / totalWorkingPopulation

            //total number of currently working teachers:
            //int totalTeacher = 0; //nicht hier, sondern als property oder rückgabevariable
            ////durchlaufen aller objekte in List<Profession> in Datacoordinator schools
            //foreach (var prof in schools.Professions)
            //    if (prof.Name == "teacher") //objekt für teacher heraussuchen
            //    {
            //        foreach (var age in prof.Agegroups) //liste agegroups durchlaufen
            //            if (Youngest >= x && Oldest <= y) //altersgruppen filtern (x& y konkrete Werte!)
            //            totalTeacher += age.Number;
            //    }

            //oder mit LINQ analog zu population5

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
