using System;


    class calculation
    {   
        int population5 = 0;
        int population10 = 0;
        int population15 = 0;
        int population20 = 0;
        int populationwork = 0;
        int populationwork5 = 0;
        int populationwork10 = 0;
        int populationwork15 = 0;
        int populationwork20 = 0;
        int totalTeacher = 0;
        int students5 =  0;
        int students10 = 0;
        int students15 = 0;
        int students20 = 0;
        int teachers = 0;
        int teachers5 = 0;
        int teachers10 = 0;
        int teachers15 = 0;
        int teachers20 = 0;


        public void prediction(DataCoordinator lists, Variables var)
        //e.g. intervall = 5, number = 4: 4 predictions in intervall of 5 years -> in 5, 10, 15, 29 years
        {
        
        //1. complete population
        
            // in 5y: complete poulation until age 80y + agegroup -5 to -1
            var selectedList = from age in lists.AgeGroups
                               where age.Youngest >= -5 && age.Oldest<= 80 //life-expectation at 85 years
                               select age;
            foreach (var age in selectedList)
                population5 +=  age.Number;             

            //in 10 years
            selectedList =  from age in lists.AgeGroups
                            where age.Youngest >= -10 && age.Oldest<= 75 
                            select age;
            foreach (var age in selectedList)
                population10 +=  age.Number;  
            
            //in 15 years
            selectedList =  from age in lists.AgeGroups
                            where age.Youngest >= -15 && age.Oldest<= 70 
                            select age;
            foreach (var age in selectedList)
                population15 +=  age.Number; 
            
            //in 20 years
            selectedList =  from age in lists.AgeGroups
                            where age.Youngest >= -20 && age.Oldest<= 65 
                            select age;
            foreach (var age in selectedList)
                population20 +=  age.Number; 


        //working population
            //now
            selectedList =  from age in lists.AgeGroups
                            where age.Youngest >= var.WorkMinAge && age.Oldest<= var.WorkMaxAge
                            select age;
            foreach (var age in selectedList)
                populationwork +=  age.Number;
            
            //in 5 years
            selectedList =  from age in lists.AgeGroups
                            where age.Youngest >= (var.WorkMinAge-5) && age.Oldest<= (var.WorkMaxAge-5)
                            select age;
            foreach (var age in selectedList)
                populationwork5 +=  age.Number;

            //in 10 years
            selectedList =  from age in lists.AgeGroups
                            where age.Youngest >= (var.WorkMinAge-10) && age.Oldest<= (var.WorkMaxAge-10)
                            select age;
            foreach (var age in selectedList)
                populationwork10 +=  age.Number;
            
            //in 15 years
            selectedList =  from age in lists.AgeGroups
                            where age.Youngest >= (var.WorkMinAge-15) && age.Oldest<= (var.WorkMaxAge-15)
                            select age;
            foreach (var age in selectedList)
                populationwork15 +=  age.Number;
            
            //in 20 years
            selectedList =  from age in lists.AgeGroups
                            where age.Youngest >= (var.WorkMinAge-20) && age.Oldest<= (var.WorkMaxAge-20)
                            select age;
            foreach (var age in selectedList)
                populationwork20 +=  age.Number;



    //2. prognosis for teachers
        //total number of currently working teachers:
            //durchlaufen aller objekte in List<Profession> in Datacoordinator schools
            foreach (var prof in lists.Professions)
                if (prof.Name == "teacher") //objekt für teacher heraussuchen
                {
                    //now
                    selectedList =  from age in prof.AgeGroups
                            where age.Youngest >= (var.WorkMinAge) && age.Oldest<= (var.WorkMaxAge)
                            select age;
                    foreach (var age in selectedList)
                        teachers +=  age.Number;

                    //in 5 years
                    selectedList =  from age in prof.AgeGroups
                            where age.Youngest >= (var.WorkMinAge-5) && age.Oldest<= (var.WorkMaxAge-5)
                            select age;
                    foreach (var age in selectedList)
                        teachers5 +=  age.Number;

                    //in 10 years
                    selectedList =  from age in prof.AgeGroups
                            where age.Youngest >= (var.WorkMinAge-10) && age.Oldest<= (var.WorkMaxAge-10)
                            select age;
                    foreach (var age in selectedList)
                        teachers10 +=  age.Number;

                    //in 15 years
                    selectedList =  from age in prof.AgeGroups
                            where age.Youngest >= (var.WorkMinAge-15) && age.Oldest<= (var.WorkMaxAge-15)
                            select age;
                    foreach (var age in selectedList)
                        teachers15 +=  age.Number;

                    //in 20 years
                    selectedList =  from age in prof.AgeGroups
                            where age.Youngest >= (var.WorkMinAge-20) && age.Oldest<= (var.WorkMaxAge-20)
                            select age;
                    foreach (var age in selectedList)
                        teachers20 +=  age.Number;
                }


        //3. prognosis for children/students
            
            //in 5 years
            selectedList =  from age in lists.AgeGroups
                            where age.Youngest >= (5-5) && age.Oldest <= (19-5) //ageGroups 5-9,10-14, 15-19 in 5 years  
                            select age;
            foreach (var age in selectedList)
                students5 +=  age.Number; 
            
            //in 10 years
            selectedList =  from age in lists.AgeGroups
                            where age.Youngest >= (5-10) && age.Oldest <= (19-10)  
                            select age;
            foreach (var age in selectedList)
                students10 +=  age.Number; 

            //in 15 years
            selectedList =  from age in lists.AgeGroups
                            where age.Youngest >= (5-15) && age.Oldest <= (19-15)  
                            select age;
            foreach (var age in selectedList)
                students15 +=  age.Number; 

            //in 20 years
            selectedList =  from age in lists.AgeGroups
                            where age.Youngest >= (5-20) && age.Oldest <= (19-20)  
                            select age;
            foreach (var age in selectedList)
                students20 +=  age.Number; 

        //4. prognosis infrastructure
            int schools = var.NumberBuildings1;
        }


        double teachersneeded5 = 0;
        double teachersneeded10 = 0;
        double teachersneeded15 = 0;
        double teachersneeded20 = 0;
        double schoolsneeded5 = 0;
        double schoolsneeded10 = 0;
        double schoolsneeded15 = 0;
        double schoolsneeded20 = 0;
        public void calculator(Variables var)
        {
        //1. needed teachers
            // amount of students divided by StudentsPerTeacher
            //optimal StudentsPerTeacher by 20
            teachersneeded5 = students5 / 20;
            teachersneeded10 = students10 / 20;
            teachersneeded15 = students15 / 20;
            teachersneeded20 = students20 / 20;
        //2. needed schools
            // amount of students divided by StudentsPerSchool
            schoolsneeded5 = students5 / var.AverageCapacity1;
            schoolsneeded10 = students10 / var.AverageCapacity1;
            schoolsneeded15 = students15 / var.AverageCapacity1;
            schoolsneeded20 = students20 / var.AverageCapacity1;
        }
    }

