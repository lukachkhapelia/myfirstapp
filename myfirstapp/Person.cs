using System;
using System.Collections.Generic;
using System.Text;

namespace myfirstapp
{
    class Person
    {
        public string Firstname, Lastname;
        public int Group, Id;
        private static int count = 0;

        public Person(string Firstname, string Lastname,int Group)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Group = Group;
            Id = ++count;
        }

        public Person()
        {
            this.Firstname = "";
            this.Lastname = "";
            this.Group = 0;
            Id = ++count;
        }
        public override string ToString()
        {
            return $"Firstname: {Firstname} Lastname: {Lastname} Group: {Group} Id: {Id}"; ;
        }
    }
}
