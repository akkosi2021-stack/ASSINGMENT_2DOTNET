using System;

namespace StudentLibrary
{
    public class Student
    {
        // Different access modifiers

        public string Name;
        private int Age;
        protected string Department;
        internal double CGPA;
        protected internal string College;
        private protected string Address;


        // Public method
        public void Display()
        {
            Console.WriteLine("----- Student Details -----");

            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("CGPA: " + CGPA);
            Console.WriteLine("College: " + College);
            Console.WriteLine("Address: " + Address);
        }
    }
}
