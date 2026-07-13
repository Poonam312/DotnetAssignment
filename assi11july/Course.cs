using System;
using System.Collections.Generic;
using System.Linq;

class Course
{
    public string CourseId;
    public string CourseName;
    public int Credits;

    public Course(string id, string name, int credits)
    {
        CourseId = id;
        CourseName = name;
        Credits = credits;
    }
}

class Student
{
    public int StudentId;
    public string StudentName;
    public string Department;
    public string StudentType;
    public List<Course> EnrolledCourses = new List<Course>();

    public Student(int id, string name, string dept, string type)
    {
        StudentId = id;
        StudentName = name;
        Department = dept;
        StudentType = type;
    }

    public int TotalCredits()
    {
        int total = 0;
        foreach (Course c in EnrolledCourses)
        {
            total += c.Credits;
        }
        return total;
    }

    public double CalculateFee()
    {
        int credits = TotalCredits();

        if (StudentType == "Regular")
            return credits * 5000;

        else if (StudentType == "Scholarship")
            return credits * 2500;

        else
            return credits * 3000;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        List<Course> courses = new List<Course>();

        while (true)
        {
            Console.WriteLine("\n===== STUDENT MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Register Student");
            Console.WriteLine("2. Add Course");
            Console.WriteLine("3. View Students");
            Console.WriteLine("4. View Courses");
            Console.WriteLine("5. Register Course");
            Console.WriteLine("6. Display Student Details");
            Console.WriteLine("7. Exit");

            Console.Write("Enter Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Student ID : ");
                    int sid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Student Name : ");
                    string sname = Console.ReadLine();

                    Console.Write("Department : ");
                    string dept = Console.ReadLine();

                    Console.Write("Student Type (Regular/Scholarship/Part-Time): ");
                    string type = Console.ReadLine();

                    students.Add(new Student(sid, sname, dept, type));
                    Console.WriteLine("Student Registered Successfully");
                    break;

                case 2:
                    Console.Write("Course ID : ");
                    string cid = Console.ReadLine();

                    Console.Write("Course Name : ");
                    string cname = Console.ReadLine();

                    Console.Write("Credits : ");
                    int credit = Convert.ToInt32(Console.ReadLine());

                    courses.Add(new Course(cid, cname, credit));

                    Console.WriteLine("Course Added Successfully");
                    break;

                case 3:

                    Console.WriteLine("\nRegistered Students");

                    foreach (Student s in students)
                    {
                        Console.WriteLine($"{s.StudentId}  {s.StudentName}  {s.Department}  {s.StudentType}");
                    }

                    break;

                case 4:

                    Console.WriteLine("\nAvailable Courses");

                    foreach (Course c in courses)
                    {
                        Console.WriteLine($"{c.CourseId}  {c.CourseName}  {c.Credits}");
                    }

                    break;
                                    case 5:

                    Console.Write("Enter Student ID : ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Student student = students.Find(x => x.StudentId == id);

                    if (student == null)
                    {
                        Console.WriteLine("Student Not Found");
                        break;
                    }

                    if (student.EnrolledCourses.Count >= 5)
                    {
                        Console.WriteLine("Maximum 5 Courses Allowed");
                        break;
                    }

                    Console.Write("Enter Course ID : ");
                    string courseId = Console.ReadLine();

                    Course course = courses.Find(x => x.CourseId == courseId);

                    if (course == null)
                    {
                        Console.WriteLine("Course Not Found");
                        break;
                    }

                    bool found = false;

                    foreach (Course c in student.EnrolledCourses)
                    {
                        if (c.CourseId == courseId)
                        {
                            found = true;
                            break;
                        }
                    }

                    if (found)
                    {
                        Console.WriteLine("Course Already Registered");
                    }
                    else
                    {
                        student.EnrolledCourses.Add(course);
                        Console.WriteLine("Course Registered Successfully");
                    }

                    break;

                case 6:

                    Console.Write("Enter Student ID : ");
                    int stuId = Convert.ToInt32(Console.ReadLine());

                    Student s1 = students.Find(x => x.StudentId == stuId);

                    if (s1 == null)
                    {
                        Console.WriteLine("Student Not Found");
                        break;
                    }

                    Console.WriteLine("\n----- Student Details -----");
                    Console.WriteLine("Student ID : " + s1.StudentId);
                    Console.WriteLine("Student Name : " + s1.StudentName);
                    Console.WriteLine("Department : " + s1.Department);
                    Console.WriteLine("Student Type : " + s1.StudentType);

                    Console.WriteLine("\nEnrolled Courses");

                    foreach (Course c in s1.EnrolledCourses)
                    {
                        Console.WriteLine(c.CourseId + "  " + c.CourseName + "  Credits : " + c.Credits);
                    }

                    Console.WriteLine("\nTotal Credits : " + s1.TotalCredits());
                    Console.WriteLine("Total Fee : " + s1.CalculateFee());

                    break;

                case 7:

                    Console.WriteLine("Thank You");
                    return;

                default:

                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}