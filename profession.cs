class Profession
{
<<<<<<< Updated upstream
    List<AgeGroup>? AgeGroups;
=======
    List<AgeGroup>? AgeGroups;
>>>>>>> Stashed changes

    public int TotalNumber = 0;

    //Konstruktor
<<<<<<< Updated upstream
    Profession(int total)
=======
    public Profession(int total)
>>>>>>> Stashed changes
    {
        AgeGroups=null;
        TotalNumber = total;
    }

<<<<<<< Updated upstream
    Profession (List<AgeGroup> ages) {
=======
    public Profession (List<AgeGroup> ages) {
>>>>>>> Stashed changes
        AgeGroups = ages;
        foreach (AgeGroup age in AgeGroups) TotalNumber += age.Number;
    }

<<<<<<< Updated upstream
    Profession (List<AgeGroup> ages, int total) {
=======
    public Profession (List<AgeGroup> ages, int total) {
>>>>>>> Stashed changes
        AgeGroups = ages;
        TotalNumber = total;
    }

}