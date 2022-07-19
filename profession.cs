class Profession
{
    List<AgeGroup>? AgeGroups;

    public int TotalNumber = 0;

    //Konstruktor
    Profession(int total)
    {
        AgeGroups=null;
        TotalNumber = total;
    }

    Profession (List<AgeGroup> ages) {
        AgeGroups = ages;
        foreach (AgeGroup age in AgeGroups) TotalNumber += age.Number;
    }

    Profession (List<AgeGroup> ages, int total) {
        AgeGroups = ages;
        TotalNumber = total;
    }

}