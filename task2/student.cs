
public class Student
{
    private string fullname;
    private int age;
    private int grade;
    public Student()
    {

    }
    public Student(string name, int age)
    {
        this.fullname = name;
        this.age = age;
    }
    public Student(string name, int age, int grade)
    {
        this.fullname = name;
        this.age = age;
        this.grade = grade;
    }
    public void Study()
    {
        Console.WriteLine($"{fullname} is student");
    }
    public void SetGrade(int grade)
    {
        this.grade = grade;
    }
    public int GetGrade()
    {
        return grade;
    }
}