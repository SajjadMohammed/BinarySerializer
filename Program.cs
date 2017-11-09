using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining an object
            var student = new Student
            {
                Id = 1,
                FullName = "Ahmed Ameen Ali",
                Address = "Kirkuk",
                Age = 23
            };

            var memoryStream = BinarySerialize(student);
            var stu = BinaryDeserialize(memoryStream.ToArray());
            Console.WriteLine($"{stu.Id} : {stu.FullName} : {stu.Address} : {stu.Age}");

            Console.ReadKey();
        }

        static MemoryStream BinarySerialize(Student student)
        {
            // Serialization steps
            using (var memoryStream = new MemoryStream())
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, student);
                return memoryStream;
            }
        }

        static Student BinaryDeserialize(byte[] bytes)
        {
            // De-Serialization steps
            using (var memoryStream = new MemoryStream(bytes))
            {
                var binaryFormatter = new BinaryFormatter();
                var student = binaryFormatter.Deserialize(memoryStream) as Student;
                return student;
            }
        }
    }
}