

public class Patient
{
    private string fullname;
    private int age;
    List<String> medicinhistory = new List<string>();
    public Patient(string fullname, int age)
    {
        this.fullname = fullname;
        this.age = age;
    }
    public string GetFullName()
    {
        return $"{fullname}";
    }
    public void AddMedRec(string record)
    {
        medicinhistory.Add(record);
    }
    public void GetMed()
    {
        int i = 1;
        foreach (var item in medicinhistory)
        {
            System.Console.WriteLine("Tarih #" + i + " - " + item + ".");
            i++;
        }
    }
}