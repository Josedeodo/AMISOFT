using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMI
{
    class Usuario : Persona
    {
        private int id;
        private string password;      

        public int Id   
        {
            get { return id; }
            set { id = value; }
        }

        private string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
