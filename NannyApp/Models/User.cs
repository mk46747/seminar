using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace NannyApp.Models
{
    public enum userType { administrator, nanny, parrent };

    public class User
    {
        private int _id;
        private string _name;
        private string _surname;
        private string _sex;
        private string _email;
        private string _password;
        private userType _userType;
        private string _contact;

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public virtual string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public virtual string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        public virtual string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public virtual string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public virtual userType UserType
        {
            get { return _userType; }
            set { _userType = value; }
        }
        public virtual string Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }
    }
}