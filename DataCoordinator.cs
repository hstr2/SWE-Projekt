class  DataCoordinator
{
    public List<AgeGroup> AgeGroups; 
    public List<Profession> Professions; 
    public List<Infrastructure> Infrastructures;

    public int TotalPeople;

    public DataCoordinator()
    {
        AgeGroups = new List<AgeGroup>();
        Professions = new List<Profession>();
        Infrastructures = new List<Infrastructure>();
    }

    public void CalculateSumAgeGroups()
    {
        foreach (var agegroup in AgeGroups)
            TotalPeople += agegroup.Number;
    }
} 