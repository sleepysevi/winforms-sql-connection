namespace TestWins.Model;


public class Student
{

    public string studentId { get; set; } //Primary Key
    // public string Name { get; set; }
    private string _name;
    public int age { get; set; }

    public string course { get; set; }


    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("Name cannot be empty.");

            _name = value;
        }
    }
}


