using System;
using System.Linq;

class Student {

  public Student(int studentId, string studentName, int age){
    StudentID = studentId;
    StudentName = studentName;
    Age = age;
  }
  
  public int StudentID {get; set; }
  public string StudentName { get; set; }
  public int Age { get; set; }
}

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    // firstLinq();
  }

  public static void firstLinq(){
    string[] names = {"Bills","Steve","James","Mohan"};

    var myLinqQuery = from name in names
                    where name.Contains('a')
                    select name;

    foreach(var name in myLinqQuery)
      Console.Write(name + " ");
  }

  public static void studentRun(){
    Student[] studentArray = {
      new Student(1,"John",18),
      new Student(2,"Steve",21),
      new Student(3,"Bill",25),
      new Student(4,"Ram",20),
      new Student(5,"Ron",31),
      new Student(6,"Chris",17),
      new Student(7,"Rob",19)
    };

    // Student[] students = new Student[10];

    // int i = 0;

    // foreach (Student std in studentArray){
      
    //   if (std.Age > 12 && std.Age < 20){
    //     students[i] = std;
    //     i++;
    //   }
    // }

    Student[] teenAgerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();  
  }
}