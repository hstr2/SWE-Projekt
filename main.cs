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

    //    foreach (var group in ageGroups)
    //    Console.WriteLine(group.ToString());

        return ageGroups;
    }


    static List<string[]> ReadData (string file) 
    { 

    //Read file line by line, create string of information in each line, store strings in list
        string line;
        List<string[]> Lines = new List<string[]>();
        StreamReader sr = new StreamReader(file);
        line = sr.ReadLine();
        while (line!= null)
        {
            string[] teile = line.Split(';');

            Lines.Add(teile);
            line = sr.ReadLine();
        }
        sr.Close();

    //test
        //foreach ( var el in Lines) 
        //{
        //    foreach (var str in el)
        //        Console.Write($"{str}\t");
        //    Console.Write("\n");
        //}

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
                     age = Convert.ToInt32(el[0]);
                     number = int.Parse(el[1]) + int.Parse(el[2]) ;
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
        Variables var = new Variables();
        var.NameVariables("variables.txt");

//Console.WriteLine($"vars: {var.MaxAge}, {var.MinAge}, {var.rangeAgeGroups}");

        DataCoordinator human = new DataCoordinator();
        human.AgeGroups = DataToAgeGroup(var.FileBevData, var.MinAge, var.MaxAge, var.RangeAgeGroups);

//test
    //    foreach (var group in human.AgeGroups)
    //    Console.WriteLine(group.ToString());

      human.Professions.Add(DataToProfession(var.Profession1, var.FileProf1, var.WorkMinAge, var.WorkMaxAge, var.RangeAgeGroups));
    }
}



/*TODO
    -exceptions
    -sinnvolle bezeichnung agegroup
*/