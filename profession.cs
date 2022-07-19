class Profession
{
    public string profession;
    List<AgeGroup>? AgeGroups;
    public int TotalNumber = 0;

    //Konstruktor
    public Profession (string name, List<AgeGroup> ages) 
    {
        profession = name;
        AgeGroups = ages;
        foreach (AgeGroup age in AgeGroups) TotalNumber += age.Number;
    }

   
    public Profession (string name, List<AgeGroup> ages, int total) 
    {
        profession = name;
        AgeGroups = ages;
        TotalNumber = total;
    }

}