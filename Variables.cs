public class Variables
{
    
    public int RangeAgeGroups;
        public int MinAge;
        public int MaxAge;
        public string FileBevData;
        public int WorkMinAge;
        public int WorkMaxAge;
        public string Profession1;
        public string FileProf1;
    
    public string[] ReadVariables(string filename)
    {   
        string[] vars = new string[9];
        string line;
        int count = 1;
        StreamReader sr = new StreamReader(filename);
        
        while (!sr.EndOfStream )
        {   line = sr.ReadLine();
            string[] teile = line.Split(':');
            vars [count] = teile[1];   
            count++;               
        }
        sr.Close();    

    //    foreach(var str in vars)
    //    Console.WriteLine($"{str}");
        
        return vars;        
    }

    public void NameVariables(string file)
    {
        string[] vars = ReadVariables(file);
        RangeAgeGroups = Convert.ToInt32(vars[1]);
        MinAge = Convert.ToInt32(vars[2]);
        MaxAge = Convert.ToInt32(vars[3]);
        FileBevData = vars[4];
        WorkMinAge = Convert.ToInt32(vars[5]);
        WorkMaxAge = Convert.ToInt32(vars[6]);
        Profession1 = vars[7];
        FileProf1= vars[8];

    }

}