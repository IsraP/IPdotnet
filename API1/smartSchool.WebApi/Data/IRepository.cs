using smartSchool.WebApi.Models;

namespace Data
{
    public interface IRepository{
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Remove<T>(T entity) where T : class;
        bool SaveChanges();

        Student[] getAllStudents(bool includeTeacher);
        Student getStudentById(int studentId, bool includeTeacher);
        Student[] getStudentsByDisciplineId(int disciplineId, bool includeTeacher);

        Teacher[] getAllTeachers(bool includeStudents);
        Teacher getTeacherById(int studentId, bool includeStudents);
        Teacher[] getTeachersByDisciplineId(int disciplineId, bool includeStudents);

    }
}