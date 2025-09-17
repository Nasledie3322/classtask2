
public class Teacher
{
    string fullName;
    string subject;
    int experience;
    public string Teach()
    {
        return $"{fullName} is teaching {subject}";
    }
    public void SetExperience(int years)
    {
        experience = years;
    }
    public int GetExperience()
    {
        return experience;
    }
    public Teacher() { }
    public Teacher(string name, string subject)
    {
        fullName = name;
        this.subject = subject;
    }
    public Teacher(string name, string subject, int experience)
    {
        fullName = name;
        this.subject = subject;
        this.experience = experience;
    }
}