using System;
using System.Collections.Generic;
using System.Data;
using Horoscop;
using Npgsql;

public class StudentDAOSQL : IStudentDAO
{
    private string connectionString = "Host=localhost;Database=Universitate;Username=postgres;Password=postgress";

    public List<Student> GetStudents()
    {
        List<Student> students = new List<Student>();

        using (var conn = new NpgsqlConnection(connectionString))
        {
            conn.Open();
            using (var cmd = new NpgsqlCommand("SELECT * FROM public.\"Students\"", conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            NumarMatricol = reader["NumarMatricol"].ToString(),
                            Nume = reader["Nume"].ToString(),
                            Medie = Convert.ToDouble(reader["Medie"])
                        });
                    }
                }
            }
        }

        return students;
    }

    public Student GetStudentByNumarMatricol(string numarMatricol)
    {
        using (var conn = new NpgsqlConnection(connectionString))
        {
            conn.Open();
            using (var cmd = new NpgsqlCommand("SELECT * FROM public.\"Students\" WHERE \"NumarMatricol\" = @numarMatricol", conn))
            {
                cmd.Parameters.AddWithValue("numarMatricol", numarMatricol);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Student
                        {
                            NumarMatricol = reader["NumarMatricol"].ToString(),
                            Nume = reader["Nume"].ToString(),
                            Medie = Convert.ToDouble(reader["Medie"])
                        };
                    }
                }
            }
        }

        return null;
    }
}
