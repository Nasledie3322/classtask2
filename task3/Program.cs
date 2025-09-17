
Doctor doctor = new Doctor("Ali Alievich", "Semeyniy", 15);
Patient patient = new Patient("Homil Karimov", 55);

Console.WriteLine(doctor.TrPatient(patient));
Console.WriteLine(doctor.PerformMedicalExamination(patient));
Console.WriteLine(doctor.PrMed(patient, "Paracetamol"));
Console.WriteLine(doctor.PrMed(patient, "Relif"));

Console.WriteLine("\nTarihi tabobati patsient");
patient.GetMed();

Console.WriteLine($"\nSoli kori duhtur: {doctor.GetExper()} sol");