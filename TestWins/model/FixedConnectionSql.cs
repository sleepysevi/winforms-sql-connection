using MySql.Data.MySqlClient;
using TestWins.Model;

namespace TestWins.Repository
{
    public class StudentRepository
    {
        private readonly FixedConnectionSql _db = new FixedConnectionSql(); 

        public void Create(Student student)
        {
            using var conn = _db.connectSql();
            conn.Open();
            string query = "INSERT INTO students (name, age, course) VALUES (@name, @age, @course)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", student.Name);
            cmd.Parameters.AddWithValue("@age", student.Age);
            cmd.Parameters.AddWithValue("@course", student.Course);
            cmd.ExecuteNonQuery();
        }

        public List<Student> GetAll() 
        {
            var list = new List<Student>();
            using var conn = _db.connectSql(); 
            conn.Open();
            string query = "SELECT * FROM students";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Student
                {
                    StudentId = reader.GetInt32(0),
                    Name     = reader.GetString(1),
                    Age      = reader.GetInt32(2),  
                    Course   = reader.GetString(3),
                });
            }
            return list;
        }

        public void Update(Student student)
        {
            using var conn = _db.connectSql();
            conn.Open();
            string query = "UPDATE students SET name = @name, age = @age, course = @course WHERE id = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id",     student.StudentId);
            cmd.Parameters.AddWithValue("@name",   student.Name);
            cmd.Parameters.AddWithValue("@age",    student.Age);    
            cmd.Parameters.AddWithValue("@course", student.Course);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = _db.connectSql();
            conn.Open();
            string query = "DELETE FROM students WHERE id = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
