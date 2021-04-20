using System;
using System.Collections.Generic;
using System.Text;

namespace LabClassUML
{
    class Person
    {
        //Properties
        private string _name;
        private string _address;

        private string Name
        {
            get { return this._name; }
            set { this._name = value; }

        }

        private string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }
        //Constructors
         public Person(string name, string address)
         {
            this._name = name;
            this._address = address;
         }

        //Method
        //Override
        public override string ToString()
        {
            return $"Person Name = {this._name} \n Address = {this._address}";
        }
    }
}
