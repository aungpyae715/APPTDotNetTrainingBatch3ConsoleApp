using ConsoleApp2;

Student student = new Student();
student.StudentNo = 1;
student.StudentName = "John Doe";
student.FatherName = "Richard Roe";

Student student2 = new Student();
student2.StudentNo = 2;
student2.StudentName = "John Doe 2";
student2.FatherName = "Richard Roe 2";
student2.DateofBirth = new DateTime(2000, 1, 1); 

Console.WriteLine(student.StudentNo);
Console.WriteLine(student2.StudentNo);

Console.Read();
