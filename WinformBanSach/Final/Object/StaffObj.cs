using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Object
{
    class StaffObj
    {
        string id_user, passwords, name_user, phone, position;
        int age;

        public string Id_user { get => id_user; set => id_user = value; }
        public string Passwords { get => passwords; set => passwords = value; }
        public string Name_user { get => name_user; set => name_user = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Position { get => position; set => position = value; }
        public int Age { get => age; set => age = value; }
        public StaffObj() { }
        public StaffObj(string id_user,string passwords,string name_user, string phone,int age, string position) {
            this.id_user = id_user;
            this.passwords = passwords;
            this.name_user = name_user;
            this.phone = phone;
            this.age = age;
            this.position = position;
        }
    }
}
