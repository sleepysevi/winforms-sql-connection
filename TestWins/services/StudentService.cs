using TestWins.Model;
using TestWins.Repoository;

namespace TestWins.Services;

public class StudentService
{
    private readonly StudentRepository _repo = new StudentRepository();

    // public void createStudent(Student s)
    // {
    //     _repo.create(s);
    // }

    public void createStudent(Student s) => _repo.create(s);
    public List<Student> getStudents() => _repo.getAll();
    public void updateStudent(Student s) => _repo.update(s);
    public void deleteStudent(string id) => _repo.delete(id);
}