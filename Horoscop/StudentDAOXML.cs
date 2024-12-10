using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Horoscop;

public class StudentDAOXML : IStudentDAO
{
    private string xmlFilePath = @"C:\Users\mihai\source\repos\Horoscop\Horoscop\student.xml";


    public List<Student> GetStudents()
    {
        XDocument doc = XDocument.Load(xmlFilePath);
        return doc.Descendants("student")
                  .Select(x => new Student
                  {
                      NumarMatricol = x.Element("NumarMatricol").Value,
                      Nume = x.Element("Nume").Value,
                      Medie = double.Parse(x.Element("Medie").Value)
                  }).ToList();
    }

    public Student GetStudentByNumarMatricol(string numarMatricol)
    {
        XDocument doc = XDocument.Load(xmlFilePath);
        var element = doc.Descendants("student")
                         .FirstOrDefault(x => x.Element("NumarMatricol").Value == numarMatricol);
        if (element != null)
        {
            return new Student
            {
                NumarMatricol = element.Element("NumarMatricol").Value,
                Nume = element.Element("Nume").Value,
                Medie = double.Parse(element.Element("Medie").Value)
            };
        }
        return null;
    }

    public void AddStudent(Student student)
    {
        XDocument doc = XDocument.Load(xmlFilePath);
        XElement newStudent = new XElement("student",
            new XElement("NumarMatricol", student.NumarMatricol),
            new XElement("Nume", student.Nume),
            new XElement("Medie", student.Medie));

        doc.Element("students").Add(newStudent);
        doc.Save(xmlFilePath);
    }

    public bool UpdateStudent(string numarMatricol, Student updatedStudent)
    {
        XDocument doc = XDocument.Load(xmlFilePath);
        var element = doc.Descendants("student")
                         .FirstOrDefault(x => x.Element("NumarMatricol").Value == numarMatricol);
        if (element != null)
        {
            element.Element("Nume").Value = updatedStudent.Nume;
            element.Element("Medie").Value = updatedStudent.Medie.ToString();
            doc.Save(xmlFilePath);
            return true;
        }
        return false;
    }

    public bool DeleteStudent(string numarMatricol)
    {
        XDocument doc = XDocument.Load(xmlFilePath);
        var element = doc.Descendants("student")
                         .FirstOrDefault(x => x.Element("NumarMatricol").Value == numarMatricol);
        if (element != null)
        {
            element.Remove();
            doc.Save(xmlFilePath);
            return true;
        }
        return false;
    }
}