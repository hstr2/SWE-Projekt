class  DataCoordinator
{
    public List<AgeGroup>? AgeGroups; 
    public List<Profession> ? Professions; 

    public int TotalPeople;

    public DataCoordinator(int minAge, int maxAge, int ageRange)
    {
        AgeGroups = new List<AgeGroup>();
         for (int i = minAge; i <= maxAge; i += ageRange) //zB 0-4 bei agerange 5, nächste altersgruppe 5-9
        {
            AgeGroup a = new AgeGroup(i, i+ageRange-1);
            AgeGroups.Add(a);                                          
        }
    }

    public List<string[]> ReadData (string file) 
    { 

    //Read file line by line, create string of information in each line, store strings in list
        string line;
        List<string[]> Lines = new List<string[]>();
        StreamReader sr = new StreamReader(file);
        line = sr.ReadLine();
        while (line!= null)
        {
            string[] teile = line.Split(';');

        //eliminieren zeilen ohne alterswert
        //funktioniert nicht. warum???
            //  try{
            //      int x = Convert.ToInt32(teile[0]);
            //  }
            //  catch(FormatException){
            //      line = sr.ReadLine();
            //      if (line!= null) {
            //          teile = line.Split(';');
            //      } else {
            //          break;
            //      }
            //  }

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

    public void DataToHumanClass(string file)
    {
        List<string[]> Lines = ReadData(file);
        foreach (var el in Lines)
        {
            foreach(var agegroup in AgeGroups)
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
    }

}


/*TODO
    -exceptions
    -sinnvolle bezeichnung agegroup
*/
    
