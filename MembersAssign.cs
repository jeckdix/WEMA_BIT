
class MembersAssign
{
    public static void Main ()
    {
        School mySchool = new School("Baptist High School", SchoolType.HighSchool);

        mySchool.DisplaySchoolInfo();


    }
}

public class School : ISchoolEntity
{
    
    private string schoolName;
    private SchoolType schoolType;


    public string SchoolName
    {
        get { return schoolName; }
        set { schoolName = value; }
    }

    public SchoolType SchoolType
    {
        get { return schoolType; }
        set { schoolType = value; }
    }

    public string EntityName
    {
        get { return schoolName; }
        set { schoolName = value; }
    }


    public School(string schoolName, SchoolType schoolType)
    {
        this.schoolName = schoolName;
        this.schoolType = schoolType;
        Console.WriteLine("School instance created.");
    }

    ~School()
    {
        Console.WriteLine("School instance destroyed.");
    }
    public void DisplaySchoolInfo()
    {
        Console.WriteLine($"School: {schoolName}, Type: {schoolType}");
    }


    public event SchoolEventHandler SchoolEventOccurred;

    public void TriggerEvent(string eventName, DateTime eventDate)
    {
        SchoolEventOccurred?.Invoke($"{eventName} on {eventDate}");
    }
}

public enum SchoolType
{
    Primary,
    Secondary,
    HighSchool
}
public interface ISchoolEntity
{
    string EntityName { get; set; }
}

public delegate void SchoolEventHandler(string message);

public record SchoolEvent(string EventName, DateTime EventDate);
