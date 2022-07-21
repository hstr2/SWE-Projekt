class Profession
{

    public string Name;
    public List<AgeGroup>? AgeGroups;

    public int TotalNumber = 0;

    //Konstruktor
    public Profession(string profession, int total)
    {
        AgeGroups=null;
        TotalNumber = total;
        Name = profession;
    }


    public Profession (string profession, List<AgeGroup> ages) 
    {
        Name  = profession;
        AgeGroups = ages;
        foreach (AgeGroup age in AgeGroups) TotalNumber += age.Number;
    }

    public Profession (string profession, List<AgeGroup> ages, int total) 
    {
        Name = profession;
        AgeGroups = ages;
        TotalNumber = total;
    }

    public override string ToString()
    {
        return $"{Name}:";
    }

}