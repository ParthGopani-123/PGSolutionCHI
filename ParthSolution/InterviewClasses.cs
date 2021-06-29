using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewQuestion.Models
{
  
    public enum Gender
    {
        Male = 'M',
        Female = 'F'
    }

  
    public interface IPet
    {
        int ID { get; set; }
        string Name { get; set; }
        DateTime DateOfBirth { get; set; }
        Gender Gender { get; set; }

        string Speak();
    }

   
    public abstract class PetBase : IPet
    {
        public abstract int ID { get; set; }
        public abstract string Name { get; set; }
        public abstract DateTime DateOfBirth { get; set; }
        public abstract Gender Gender { get; set; }
        public abstract string Speak();


  
        public virtual bool IsNameAPalindrome
        {
            get
            {
                int length = Name.Length;
                string lowerName = Name.ToLower();
                for (int i = 0; i < length / 2; i++)
                {
                    if (lowerName[i] != lowerName[length - i - 1])
                        return false;
                }
                return true;
            }
        }

   
        public virtual int Age
        {
            get
            {
                int age = 0;
                age = DateTime.Now.Year - DateOfBirth.Year;

                if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                    age = age - 1;

                return age;
            }
        }
    }

    public class Bird : PetBase
    {
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override DateTime DateOfBirth { get; set; }
        public override Gender Gender { get; set; }

        public float Wingspan { get; set; }

        public override string Speak()
        {
            return "Chirp!";
        }
    }

    public class Cat : PetBase
    {
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override DateTime DateOfBirth { get; set; }
        public override Gender Gender { get; set; }

        public override string Speak()
        {
            return "Meow!";
        }
    }

    public class Dog : PetBase
    {
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override DateTime DateOfBirth { get; set; }
        public override Gender Gender { get; set; }

        public override string Speak()
        {
            return "Whoof!";
        }
    }

    public class House : List<PetBase>
    {
        public void AddTestData()
        {
            this.Add(new Cat()
            {
                ID = this.Count + 1,
                Name = "Gracie",
                DateOfBirth = new DateTime(2016, 09, 28),
                Gender = Gender.Female
            });

            this.Add(new Cat()
            {
                ID = this.Count + 1,
                Name = "Patches",
                DateOfBirth = new DateTime(2015, 01, 09),
                Gender = Gender.Male
            });

            this.Add(new Bird()
            {
                ID = this.Count + 1,
                Name = "Izzi",
                DateOfBirth = new DateTime(2018, 06, 03),
                Gender = Gender.Female,
                Wingspan = 10.0f,
            });

            this.Add(new Dog()
            {
                ID = this.Count + 1,
                Name = "Missy",
                DateOfBirth = new DateTime(2016, 03, 05),
                Gender = Gender.Female
            });
        }
    }
}