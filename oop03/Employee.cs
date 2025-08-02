using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oop03
{
    internal class Employee
    {
        public int Id { set; get; }
        public string? Name { set; get; }
        public int Salary { set; get; }
        public SecurityLevel SecurityLevel { set; get; }
        public Gender Gender { set; get; }
        public HireDate? HireDate { set; get; }


        #region Constructor

        public Employee() {
            Id = default;
            Name = default;
            Salary = default;
            SecurityLevel = default;
            Gender = default;
            HireDate = default;
        }
        public Employee(int id, string name, Gender gender, int salary, SecurityLevel securityLevel, HireDate hireDate)
        {
            Id = id;
            Name = name;
            Gender = gender;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"ID: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Gender: {Gender}\n" +
                   $"Security Level: {SecurityLevel}\n" +
                   $"Salary: {Salary}\n" +
                   $"Hire Date: {HireDate}";
        }
        #endregion
    }
}
