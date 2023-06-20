 
 class Person
{
    //const age ;
    //private Person[] _person;

    public Person( age,  id,  name,  gender : GenderType., float height, float weight)
    {
        _age = age;
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
}