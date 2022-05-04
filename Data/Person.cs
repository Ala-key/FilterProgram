using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Data
{
    class Person
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public static Person[] GetPerson()
        {
            var result = new Person[]
            {
               new Person(){ FirstName = "Алексей", LastName = "Иванов"},
               new Person(){ FirstName = "Артём", LastName = "Смирнов"},
               new Person(){ FirstName = "Сергей", LastName = "Кузнецов"},
               new Person(){ FirstName = "Вадим", LastName = "Попов"},
               new Person(){ FirstName = "Валентин", LastName = "Васильев"},
               new Person(){ FirstName = "Данил", LastName = "Соколов"},
               new Person(){ FirstName = "Максим", LastName = "Волков"},
               new Person(){ FirstName = "Матвей", LastName = "Алексеев"},
               new Person(){ FirstName = "Ирина", LastName = "Михайловна"},
               new Person(){ FirstName = "Оксана", LastName = "Егорова"},
               new Person(){ FirstName = "Ольга", LastName = "Козлова"},
               new Person(){ FirstName = "Татьяна", LastName = "Степанова"},
               
            };

            

            return result;
        }
    }
}
