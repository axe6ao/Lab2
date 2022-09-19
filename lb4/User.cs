using System;

namespace lb4
{
    internal class User
    {
        public User()
        {
            DateSubmited = DateTime.UtcNow;
        }

        public string Login { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public DateTime DateSubmited { get; }
    }
}