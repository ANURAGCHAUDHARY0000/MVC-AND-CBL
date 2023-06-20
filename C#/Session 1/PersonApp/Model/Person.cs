using PersonApp.CustomExcepton;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp.Model
{
    internal class Person
    {
        private int _age;
       
        public Person(int age, int id, string name, GenderType gender, float height, float weight)
        {
            Age = age;
            Id = id;
            Name = name;
            Gender = gender;
            Height = height;
            Weight = weight;
          
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value < 100)
                    _age = value;
                else
                    throw new InvalidAgeException();
            }
        }

        public GenderType Gender { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }


        public float BMI
        {
            get { return Weight / (Height * Height); }
        }

        public void WorkOut()
        {
            Height = Height + (Height * .10f);
            Weight = Weight - (Weight * .02f);
        }

        public override string ToString()
        {
            return Age + " " + Id + " " + Name + " " +
                Gender + " " + Height + " " + Weight + " " +
                 BMI + " ";

        }
    }
}
