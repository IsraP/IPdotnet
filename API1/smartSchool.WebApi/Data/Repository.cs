using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using smartSchool.WebApi.Models;

namespace Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;

        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Remove<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public Student[] getAllStudents(bool includeTeacher = false)
        {
            IQueryable<Student> query = _context.Students;

            if(includeTeacher){
                query = query.Include(stu => stu.Disciplines)
                .ThenInclude(sd => sd.Discipline)
                .ThenInclude(dis => dis.Teacher);
            }

            query = query.AsNoTracking()
            .OrderBy(stu => stu.Id);

            return query.ToArray();
        }

        public Student getStudentById(int studentId, bool includeTeacher = false)
        {
            IQueryable<Student> query = _context.Students;

            if(includeTeacher){
                query = query.Include(stu => stu.Disciplines)
                .ThenInclude(sd => sd.Discipline)
                .ThenInclude(dis => dis.Teacher);
            }

            query = query.AsNoTracking()
            .OrderBy(stu => stu.Id)
            .Where(stu => stu.Id == studentId);

            return query.FirstOrDefault();
        }

        public Student[] getStudentsByDisciplineId(int disciplineId, bool includeTeacher = false)
        {
            IQueryable<Student> query = _context.Students;

            if(includeTeacher){
                query = query.Include(stu => stu.Disciplines)
                .ThenInclude(sd => sd.Discipline)
                .ThenInclude(dis => dis.Teacher);
            }

            query = query.AsNoTracking()
            .OrderBy(stu => stu.Id)
            .Where(stu => stu.Disciplines.Any(sd => sd.DisciplineId == disciplineId));

            return query.ToArray();
        }

        public Teacher[] getAllTeachers(bool includeStudents = false)
        {
            IQueryable<Teacher> query = _context.Teachers;

            if(includeStudents){
                query = query.Include(teach => teach.Disciplines)
                .ThenInclude(dis => dis.StudentsDisciplines)
                .ThenInclude(sd => sd.Student);
            }

            query = query.AsNoTracking()
            .OrderBy(teach => teach.Id);

            return query.ToArray();
        }

        public Teacher getTeacherById(int teacherId, bool includeStudents = false)
        {
            IQueryable<Teacher> query = _context.Teachers;

            if(includeStudents){
                query = query.Include(teach => teach.Disciplines)
                .ThenInclude(dis => dis.StudentsDisciplines)
                .ThenInclude(sd => sd.Student);
            }

            query = query.AsNoTracking()
            .OrderBy(teach => teach.Id)
            .Where(teach => teach.Id == teacherId);

            return query.FirstOrDefault();
        }

        public Teacher[] getTeachersByDisciplineId(int disciplineId, bool includeStudents = false)
        {
            IQueryable<Teacher> query = _context.Teachers;

            if(includeStudents){
                query = query.Include(teach => teach.Disciplines)
                .ThenInclude(dis => dis.StudentsDisciplines)
                .ThenInclude(sd => sd.Student);
            }

            query = query.AsNoTracking()
            .OrderBy(teach => teach.Id)
            .Where(teach => teach.Disciplines.Any(
                dis => dis.StudentsDisciplines.Any(sd => sd.DisciplineId == disciplineId)));

            return query.ToArray();
        }
    }
}