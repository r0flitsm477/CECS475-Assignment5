﻿using DataAccessLayer;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IBusinessLayer
    {
        IList<Standard> GetAllStandards();
        Standard GetStandardByID(int id);
        Standard GetStandardByName(string name);
        void AddStandard(Standard standard);

        IList<Student> GetAllStudents();
        Student GetStudentByID(int id);
        Student GetStudentByName(string name);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void RemoveStudent(Student student);
    }
}