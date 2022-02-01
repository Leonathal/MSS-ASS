using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp
{
    class Player : User
    {
        private string _user;
        private int _userId;
        private string _firstName;
        private string _lastName;
        private int _age;
        private DateTime _dateOfBirth;
        private string _email;
        private string _password;

        public Player(int userId, string firstName, string lastName, int age, DateTime dateofBirth, string email, string password)
        {
            _user = "PLAYER";
            _userId = userId;
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _dateOfBirth = dateofBirth;
            _email = email;
            _password = password;
        }

        public override string UserType { get { return _user; } }

        public override int UserId { get { return _userId; } set { _userId = value; } }

        public override string FirstName { get { return _firstName; } set { _firstName = value; } }

        public override string LastName { get { return _lastName; } set { _lastName = value; } }

        public override int Age { get { return _age; } set { _age = value; } }

        public override DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }

        public override string Email { get { return _email; } set { _email = value; } }

        public override string Password { get { return _password; } set { _password = value; } }
    }
}
