using System;

class Employee{
  private string firstname;
  private string lastname;
  private string id;
  private int age;
  private string address;
  private string phonenumber;
  private string title;
  private double yearlysalary;
  private string employmentstatus;
  
  public Employee()
  {
    firstname="unknown";
    lastname="unknown";
    id = "unknown";
    age=0;
    employmentstatus= "active";

  }
  public Employee(string empfirstname, string emplastname, string empid, int empage, string empemploymentstatus)
{
  firstname= empfirstname;
  lastname = emplastname;
  id = empid;
  age = empage;
  employmentstatus= empemploymentstatus;
}  
public void Intro()
{
   Console.WriteLine("My first name is " + firstname);
    Console.WriteLine("My last name is " + lastname);
     Console.WriteLine("My id is " + id);
      Console.WriteLine("My age is " + age);
      Console.WriteLine("My employmentstatus is " + employmentstatus);
}

}