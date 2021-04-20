using System;
using System.Collections.Generic;
using System.Text;

namespace LabClassUML
{
    class Staff : Person
    {
        //properties
        private string _school;
        private double _pay;

        public string School
        {
            get { return this._school; }
            set { this._school = value; }
        }

        public double Pay
        {
            get { return this._pay; }
            set { this._pay = value; }
        }

        //Constructor
        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this._school = school;
            this._pay = pay;
        }

        //Method
        //Override
        public override string ToString()
        {
            string result = base.ToString();
            return "Staff: " + result + $"\n School = {this._school} \n Pay = {this._pay}";
        }

    }
}
