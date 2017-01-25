using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Model
{
   // public enum UserType { ADMIN, NANNY, PARENT };
    public enum Gender { MALE, FEMALE}

    public abstract class User : EntityBase<int>
    {
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual string Contact { get; set; }

        public User()
            : base()
        {
            

        }
      
        
         public User(string Username, string Password, 
             string Name, string Surname, Gender Gender, string Contact)  
             : base()
        {
            this.Username = Username;
            this.Password = Password;
            this.Name = Name;
            this.Surname = Surname;
            this.Gender = Gender;
            this.Contact = Contact;

        }

    }
}
