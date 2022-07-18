public class Variables
{
    
    public int rangeAgeGroups;
        public int MinAge;
        public int MaxAge;
    
    public int[] ReadVariables(string filename)
    {   
        int[] vars = new int[4];
        string line;
        int count = 1;
        StreamReader sr = new StreamReader(filename);
        
        while (!sr.EndOfStream )
        {   line = sr.ReadLine();
            string[] teile = line.Split(':');
            vars [count] = Convert.ToInt32(teile[1]);   
            count++; 
            //line = sr.ReadLine();                   
        }
        sr.Close();    

        return vars;

        // foreach(var str in vars)
        // Console.WriteLine($"{str}");
    }

    public void NameVariables(string filename)
    {
        int[] vars = ReadVariables(filename);
        this.rangeAgeGroups = vars[1];
        this.MinAge = vars[2];
        this.MaxAge = vars[3];
    }

}