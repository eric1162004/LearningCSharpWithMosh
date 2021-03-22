using System;

namespace Classes
{
    public class Person
    {
        public string Name;
        private DateTime _birthday;
        public DateTime SpecialDate { get; private set; }

        public int Age 
        {
            get
            {
                var timeSpan = DateTime.Today - SpecialDate;
                var year = timeSpan.Days / 365;
                return year;
            }
        }

        public void SetBirthday(DateTime birthday)
        {
            _birthday = birthday;
        }

        public DateTime GetBirthdate()
        {
            return _birthday;
        }

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I am {Name}");
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

}
