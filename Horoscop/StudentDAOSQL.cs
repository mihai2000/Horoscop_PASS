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
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var command = new NpgsqlCommand("SELECT * FROM public.\"Students\"", connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                students.Add(new Student
                {
                    NumarMatricol = reader["NumarMatricol"].ToString(),
                    Nume = reader["Nume"].ToString(),
                    Medie = double.Parse(reader["Medie"].ToString())
                });
            }
        }
        return students;
    }

    public Student GetStudentByNumarMatricol(string numarMatricol)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var command = new NpgsqlCommand("SELECT * FROM public.\"Students\" WHERE \"NumarMatricol\" = @numarMatricol", connection);
            command.Parameters.AddWithValue("numarMatricol", numarMatricol);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return new Student
                {
                    NumarMatricol = reader["NumarMatricol"].ToString(),
                    Nume = reader["Nume"].ToString(),
                    Medie = double.Parse(reader["Medie"].ToString())
                };
            }
        }
        return null;
    }

    public void AddStudent(Student student)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var command = new NpgsqlCommand("INSERT INTO public.\"Students\" (\"NumarMatricol\", \"Nume\", \"Medie\") VALUES (@numarMatricol, @nume, @medie)", connection);
            command.Parameters.AddWithValue("numarMatricol", student.NumarMatricol);
            command.Parameters.AddWithValue("nume", student.Nume);
            command.Parameters.AddWithValue("medie", student.Medie);
            command.ExecuteNonQuery();
        }
    }

    public bool UpdateStudent(string numarMatricol, Student updatedStudent)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var command = new NpgsqlCommand("UPDATE public.\"Students\" SET \"Nume\" = @nume, \"Medie\" = @medie WHERE \"NumarMatricol\" = @numarMatricol", connection);
            command.Parameters.AddWithValue("numarMatricol", numarMatricol);
            command.Parameters.AddWithValue("nume", updatedStudent.Nume);
            command.Parameters.AddWithValue("medie", updatedStudent.Medie);
            int rowsAffected = command.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }

    public bool DeleteStudent(string numarMatricol)
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            var command = new NpgsqlCommand("DELETE FROM public.\"Students\" WHERE \"NumarMatricol\" = @numarMatricol", connection);
            command.Parameters.AddWithValue("numarMatricol", numarMatricol);
            int rowsAffected = command.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }
}