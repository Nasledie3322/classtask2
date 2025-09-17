
Teacher teacher1 = new Teacher("Malim Malimov", "matem", 10);
teacher1.Teach();
teacher1.SetExperience(10);
teacher1.GetExperience();
System.Console.WriteLine(teacher1.Teach());
System.Console.WriteLine($"{teacher1.GetExperience()} years of experience");