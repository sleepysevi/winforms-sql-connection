using TestWins.Model;
using TestWins.Services;

namespace TestWins.Controller;


public class StudentController
{

    private readonly StudentService _service = new StudentService();

    public void createStudent(Student s) => _service.createStudent(s);
    public List<Student> getAll() => _service.getStudents();
    public void update(Student s) => _service.updateStudent(s);

    public void delete(string id) => _service.deleteStudent(id);
}