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
}

