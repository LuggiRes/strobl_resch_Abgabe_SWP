using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resthome_Database
{
    internal class Personal
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        
        public Personal() 
        {

        }

        public Personal(string firstname, string lastname, int id, int age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;  
            this.Id = id;
            this.Age = Age; 
        }
    }
}
