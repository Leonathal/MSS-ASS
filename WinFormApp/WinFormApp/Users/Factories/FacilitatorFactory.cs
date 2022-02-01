using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp
{
    class FacilitatorFactory : UserFactory
    {
        private int _userId;
        private string _firstName;
        private string _lastName;
        private int _age;
        private DateTime _dateOfBirth;
        private string _email;
        private string _password;

        public FacilitatorFactory(int userId, string firstName, string lastName, int age, DateTime dateofBirth, string email, string password)
        {
            _userId = userId;
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _dateOfBirth = dateofBirth;
            _email = email;
            _password = password;
        }

        public override User GetUserType()
        {
            return new Facilitator(_userId, _firstName, _lastName, _age, _dateOfBirth, _email, _password);
        }
    }
}
