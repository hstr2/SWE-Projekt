public class Variables
{
    
    public int RangeAgeGroups;
    public int MinAge;
    public int MaxAge;
    public string? FileBevData;
    public int WorkMinAge;
    public int WorkMaxAge;
    public string? Profession1;
    public string? FileProf1;
    public string? Building1;
    public int NumberBuilding1;
    public double AverageCapacity1;
    
    public string[] ReadVariables(string filename)
    {   
        string[] vars = new string[13];
        string? line;
        int count = 1;
        try
        {
            StreamReader sr = new StreamReader(filename);
            line = sr.ReadLine();
            while (line != null )
            {   string[] teile = line.Split(':');
                vars [count] = teile[1];   
                count++;             
                line = sr.ReadLine();
            }
            sr.Close(); 
        }
        catch(FileNotFoundException)   
        {
            Console.WriteLine("Your File is incorrect. Please check it before trying again.");
            Environment.Exit(0);
        }
        
        return vars;        
    }

    public void NameVariables(string file)
    {
        try
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
            Building1 = vars[9];
            NumberBuilding1 = Convert.ToInt32(vars[10]);
            AverageCapacity1 = Convert.ToDouble(vars[11]);
        }
        catch(FormatException)
        {
            Console.WriteLine("There is a mistake concerning the format of your variables. Please check it before trying again.");
            Environment.Exit(0);
        }
    }

}
