using ClinicSystemDataAccess;
using System;

namespace ClinicSystemBusiness
{
    public class Person
    {
        public enum Mode { Add, Update };
        private Mode _Mode;
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }

        private Person(int Id, string Name, DateTime BirthDate, string Gender, string Phone, string Email, string Country, string Address, string ImagePath)
        {
            this.Id = Id;
            this.Name = Name;
            this.BirthDate = BirthDate;
            this.Country = Country;
            this.Gender = Gender;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.ImagePath = ImagePath;

            _Mode = Mode.Update;
        }
        public Person()
        {
            this.Id = -1;
            this.Name = string.Empty;
            this.BirthDate = DateTime.MinValue;
            this.Country = string.Empty;
            this.Gender = string.Empty;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.Address = string.Empty;
            this.ImagePath = string.Empty;
            _Mode = Mode.Add;
        }
        private bool _Add()
        {
            this.Id = PersonData.Add(this.Name, this.BirthDate, this.Gender, this.Phone, this.Email, this.Country, this.Address, this.ImagePath);
            return (Id != -1);
        }
        private bool _Update()
        {
            return PersonData.Update(this.Id, this.Name, this.BirthDate, this.Gender, this.Phone, this.Email, this.Country, this.Address, this.ImagePath);
        }
        static public bool DeletePerson(int Id)
        {
            return PersonData.Delete(Id);
        }
        private bool ReadyPerson()
        {
            if (this.Name == null || this.BirthDate == null || this.Gender == null || this.Phone == null || this.Email == null || this.Country == null || this.Address == null)
            {
                return false;
            }
            return true;
        }
        public bool Save()
        {
            if (!ReadyPerson())
            {
                return false;
            }
            switch (this._Mode)
            {
                case Mode.Add:
                    return _Add();
                case Mode.Update:
                    return _Update();
            }
            return false;
        }
        public static Person Find(int Id)
        {
            string Name = string.Empty;
            DateTime BirthDate = DateTime.MinValue;
            string Gender = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            string Country = string.Empty;
            string Address = string.Empty;
            string ImagePath = string.Empty;

            if (PersonData.GetPersonById(Id, ref Name, ref BirthDate, ref Gender, ref Phone, ref Email, ref Country, ref Address, ref ImagePath))

            {
                return new Person(Id, Name, BirthDate, Gender, Phone, Email, Country, Address, ImagePath);
            }
            return null;
        }
        static public bool Exist(int Id)
        {
            return PersonData.Exist(Id);
        }
    }
}
