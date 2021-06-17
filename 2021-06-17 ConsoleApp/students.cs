﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_06_17_ConsoleApp
{
    class Student
    {
        private string name;
        private string surname;
        private int age;
        private int[] grades;

        public Student()
        {

        }

        public Student(string name, string surname, int age, int[] grades)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.grades = grades;
        }
        public string  GetName()
        {
            return this.name;
        }

        public string GetSurname()
        {
            return this.surname;
        }
        public int GetAge()
        {
            return this.age;
        }
        public int[] GetGrades()
        {
            return this.grades;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSurame(string surname)
        {
            this.surname = surname;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public void SetGrades(int[] grades)
        {
            this.grades = grades;
        }


        public double avg() //vidurkio skaičiavimas
        {
            if (this.grades.Length == 0)
            {
                return 0.0;
            }
            int sum = 0;
            for (int i = 0; i < this.grades.Length; i++)
            {
                sum += this.grades[i];
            }
            return sum/this.grades.Length;
        }
        public override string ToString()
        {
            string student = "name " + this.name + " surname " + this.surname + " age " + this.age + " marks:";
            for (int i = 0; i < this.grades.Length; i++)
            {
                student += this.grades[i] + ", ";
            }
            
            return student + "average - " + this.avg();
        }


    }
}
