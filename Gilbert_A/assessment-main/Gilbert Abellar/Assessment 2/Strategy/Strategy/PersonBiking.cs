namespace Strategy;

[ClassInterface(ClassInterfaceType.None)]
public class PersonBiking : IPersonBiking
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly float mDistance;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly IPerson mPerson;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly IBiking mBiking;

    public PersonBiking(IPerson person, IBicycle bicycle, float distanceKm)
    {
        mPerson = person;
        mDistance = distanceKm;
        mBiking = new BikingFast(bicycle);
        if (person.Age > 55) mBiking = new BikingSlow(bicycle);
    }

    private static string TimeToWordings(double seconds)
    {
        TimeSpan mTime = TimeSpan.FromSeconds(seconds);
        string mDays = ((mTime.Days <= 0) ? string.Empty : $"{mTime.Days} day{((mTime.Days > 1) ? "s" : string.Empty)}");
        string mHours = ((mTime.Hours <= 0) ? string.Empty : $"{mTime.Hours} hour{((mTime.Hours > 1) ? "s" : string.Empty)}");
        string mMinutes = ((mTime.Minutes <= 0) ? string.Empty : $"{mTime.Minutes} minute{((mTime.Minutes > 1) ? "s" : string.Empty)}");
        string mSeconds = ((mTime.Seconds <= 0) ? string.Empty : $"{mTime.Seconds} seconds{((mTime.Seconds > 1) ? "s" : string.Empty)}");
        string mText = string.Join(",", new string[] { mDays, mHours, mMinutes, mSeconds });
        string[] mChunks = mText.Split(",", StringSplitOptions.RemoveEmptyEntries);
        mText = string.Join(",", mChunks);
        int mPos = mText.LastIndexOf(",");
        if (mPos > 0 && mPos < mText.Length) mText = mText.Remove(mPos, 1).Insert(mPos, " and");
        while (mText.StartsWith(", "))
            mText = mText[2..];
        return mText;
    }

    public string GetPersonAverageBikingSpeed() => $"{mPerson.Name} can achieve {((mPerson.Gender == Gender.Male) ? "his" : "her")} {mDistance} km destination in about {TimeToWordings(mBiking.Bike(mPerson, mDistance)):HH:mm:ss}.";
}