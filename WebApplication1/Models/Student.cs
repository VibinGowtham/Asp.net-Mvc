namespace WebApplication1.Models
{
    public class Student
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public int Batch { get; set; }
        public Student(string? name, int id, int age, int batch)
        {
            Name = name;
            Id = id;
            Age = age;
            Batch = batch;
        }


    }
}
