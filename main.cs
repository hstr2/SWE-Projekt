using System;
using System.Collections.Generic;

class Programm
{
    static private List<AgeGroup> CreateAgeGroups(int minAge, int maxAge, int ageRange)
    {
        List<AgeGroup> ageGroups = new List<AgeGroup>();

        for (int i = minAge; i <= maxAge; i += ageRange) //zB 0-4 bei agerange 5, nächste altersgruppe 5-9
        {
            AgeGroup a = new AgeGroup(i, i+ageRange-1);
            ageGroups.Add(a);                                          
        }

        return ageGroups;
    }


    static List<string[]> ReadData (string file) 
    { 

    //Read file line by line, create string of information in each line, store strings in list
        string? line;
        List<string[]> Lines = new List<string[]>();
        try
        {
            StreamReader sr = new StreamReader(file);
            line = sr.ReadLine();
            while (line!= null)
            {
                string[] teile = line.Split(';');

                Lines.Add(teile);
                line = sr.ReadLine();
            }
            sr.Close();
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("Your File is incorrect. Please check it before trying it again.");
            Environment.Exit(0);
        }

        return Lines;
    }   

    static List<AgeGroup> DataToAgeGroup(string file, int minAge, int maxAge, int ageRange)
    {
        List<AgeGroup> ageGroups = CreateAgeGroups(minAge, maxAge, ageRange);
        List<string[]> Lines = ReadData(file);

        foreach (var el in Lines)
        {
            foreach(var agegroup in ageGroups)
            {
                int age;
                int number;

                try{
                     age = int.Parse(el[0]);
                     number = int.Parse(el[1]);
                }
                catch(FormatException)
                {
                    break;
                }

                if(agegroup.Youngest <= age && age <= agegroup.Oldest)
                    {
                        agegroup.Number += number;
                    }
            }
        }

        return ageGroups;
    }

    static Profession DataToProfession(string profession, string file, int minAge, int maxAge, int ageRange)
    {
        List<AgeGroup> ageGroups = DataToAgeGroup(file, minAge, maxAge, ageRange);
        Profession prof = new Profession(profession, ageGroups);
        return prof;
    }

    static void Main(string[] args)
    {   
        //read variables.txt     
        Variables var = new Variables();
        var.NameVariables("variables.txt");

        DataCoordinator schools = new DataCoordinator();
        
        //read and store data in agegroups if available
        if (var.FileBevData!=null)
        schools.AgeGroups = DataToAgeGroup(var.FileBevData, var.MinAge, var.MaxAge, var.RangeAgeGroups);
        
        //read and store data for profession1 if available
        if (var.Profession1!= null && var.FileProf1!= null)
        schools.Professions.Add(DataToProfession(var.Profession1, var.FileProf1, var.WorkMinAge, var.WorkMaxAge, var.RangeAgeGroups));
        
        //read and store data for building type 1 if available
        if (var.Building1 != null)
        {
            Infrastructure build1 = new Infrastructure(var.Building1, var.NumberBuilding1, var.AverageCapacity1);
            schools.Infrastructures.Add(build1);
        }


        Calculation calcschool = new Calculation();
        calcschool.prediction(schools, var);
        calcschool.calculator(var);

        Table table = new Table();
        table.ADONET_dynTabelle1(calcschool);


    }   
       
}



/*TODO
    -exceptions
        -ReadData
        -Variables.ReadVariables
        -variables.NameVariables
        -main
*/
