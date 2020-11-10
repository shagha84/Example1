using System;
using System.Collections.Generic;
using System.Text;

namespace Example1
{
    public class Person
    {
        public string Name;
        public int Age;
        public string Job;
        public int NumberOfCallToFullInfo;

        public Person() {
            NumberOfCallToFullInfo = 0;
        }

        public Person(string name, string job)
        {
            Name = name;
            Job = job;
            NumberOfCallToFullInfo = 0;
        }

        public Person(string name, string job, int age)
        {
            Name = name;
            Job = job;
            Age = age;
            NumberOfCallToFullInfo = 0;
        }

        public string FullInformation()
        {
            IncrementFullInfoCall();
            string fullInfo = Name + " - " + Age.ToString() + " - " + Job;
            return fullInfo;
        }

        private void IncrementFullInfoCall()
        {
            NumberOfCallToFullInfo++;
        }
    }
}
