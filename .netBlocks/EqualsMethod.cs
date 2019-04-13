// string a = "Hello";
// string b = "Hello";
// Console.WriteLine(b.Equals(a));//true, As in the string class the comparision is custom to value

// Person ob1 = new Person();
// Person ob2 = new Person();

// Console.WriteLine(ob1.Equals(ob2));//true since equals method is overridden, if not over ridden Value is False
// Console.WriteLine(ob1.GetHashCode());//0
// Console.WriteLine(ob2.GetHashCode());//0

// Animal a1 = new Animal();
// Animal a2 = new Animal();
//a1.Equals(a2);// returns false, As the default comparision is based on the Object Reference

internal class Animal
    {
    }

    internal class Person
    {
        public int idNumber { get; set; }
        public string name { get; set; }

        public override bool Equals(Object obj)
        {
            Person personObj = obj as Person;
            if (personObj == null)
                return false;
            else
                return idNumber.Equals(personObj.idNumber);
        }
        public override int GetHashCode()
        {
            return this.idNumber.GetHashCode();
        }
        //Invalid Code
        //public int GetObjHashcode()
        //{
        //    return this.GetHashCode();
        //}


    }
