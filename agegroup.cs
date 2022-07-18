public class AgeGroup
{
    public int Youngest{get;}

    public int Oldest{get;}

    public int Number;

    //konstruktoren
    public AgeGroup(int youngest, int oldest)
    {
        Youngest = youngest;
        Oldest = oldest;
    }

    public override string ToString()
    {
        return $"{Youngest} - {Oldest}: {Number}";
    }
}