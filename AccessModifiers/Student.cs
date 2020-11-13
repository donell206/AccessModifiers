using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Student
    {
        private string _name;
        const double PI = 3.14;
        private DateTime _birthdate;
        private int _age;

        public void SetName(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                this._name = name;
            }
        
         }
        public string GetName()
        {
            return _name;
        }

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthdate;
        }

        public int GetAge()
        {
           TimeSpan span = DateTime.Today - _birthdate;
            var _age = span.Days/365;
            return _age;
        }


    }
}
