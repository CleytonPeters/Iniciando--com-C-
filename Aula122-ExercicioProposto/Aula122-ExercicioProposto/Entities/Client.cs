using System;
namespace Aula122_ExercicioProposto.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string email { get; set; }
        public DateTime Birthday { get; set; }


        public Client()
        {

        }
        public Client(string name, string email, DateTime birthday)
        {
            Name = name;
            this.email = email;
            Birthday = birthday;
        }
    }
}
