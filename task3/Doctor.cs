


public class Doctor
{
    private string fullname;
    private string speciality;
    private int experies;
    List<Patient> patient = new List<Patient>();
    public Doctor()
    {
        fullname = "";
        speciality = "";
        experies = 0;
    }
    public Doctor(string fullname, string speciality)
    {
        this.fullname = fullname;
        this.speciality = speciality;
        experies = 0;
    }
    public Doctor(string fullname, string speciality, int experies)
    {
        this.fullname = fullname;
        this.speciality = speciality;
        this.experies = experies;
    }
    public string TrPatient(Patient patient)
    {
        return $"{fullname}, {speciality}, patsoentro tabobat kardan {patient.GetFullName()}";
    }
    public string PerformMedicalExamination(Patient patient)
    {
        return $"Duhtur patcientro osmotr karda istodaast {patient.GetFullName()}. Hama soz";
    }
    public string PrMed(Patient patient, string medic)
    {
        return $"{patient.GetFullName()}, Duhtur ba shumo doru menavisad {medic}";
    }
    public void SetExper(int years)
    {
        experies = years;
    }
    public int GetExper()
    {
        return experies;
    }
}