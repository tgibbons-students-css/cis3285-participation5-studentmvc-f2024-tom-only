namespace CIS3285_Unit4_StudentMVC_2024.Models
{
    public interface IStudentCRUDInterface
    {
        public List<StudentModel> getAllStudent();
        public StudentModel getStudentById(int id);
        public void AddStudent(StudentModel newStudent);
        public void UpdateStudent(int studentId, StudentModel updatedStudent);
        public void DeleteStudent(int studentId);
    }
}
