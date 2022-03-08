using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// expression body methods
namespace _15_CSharpVersions
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            fname = firstName;
            lname = lastName;
        }

        private string fname;
        private string lname;

        public override string ToString() => $"{fname} {lname}".Trim();
        public void DisplayName() => Console.WriteLine(ToString());
    }


    // Read-only properties

    public class Location
    {
        private string locationName;

        public Location(string name)
        {
            locationName = name;
        }

        public string Name => locationName;
    }

    // Properties
    public class Location1
    {
        private string locationName;

        public Location1(string name) => Name = name;

        public string Name
        {
            get => locationName;
            set => locationName = value;
        }
    }

    //Constructors
    public class Location2
    {
        private string locationName;

        public Location2(string name) => Name = name;

        public string Name
        {
            get => locationName;
            set => locationName = value;
        }
    }

    // Destroyers
    public class Destroyer
    {
        public override string ToString() => GetType().Name;

        ~Destroyer() => Console.WriteLine($"The {ToString()} finalizer is executing.");
    }

    // Indexer
    public class Sports
    {
        private string[] types = { "Baseball", "Basketball", "Football",
                              "Hockey", "Soccer", "Tennis",
                              "Volleyball" };

        public string this[int i]
        {
            get => types[i];
            set => types[i] = value;
        }
    }

}
