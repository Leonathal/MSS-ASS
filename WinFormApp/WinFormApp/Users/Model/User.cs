using System;


namespace WinFormsApp
{
    abstract class User
    {
        public abstract string UserType { get; }

        public abstract int UserId { get; set; }

        public abstract string FirstName { get; set; }

        public abstract string LastName { get; set; }

        public abstract int Age { get; set; }

        public abstract DateTime DateOfBirth { get; set; }

        public abstract string Email { get; set; }

        public abstract string Password { get; set; }
    }

}