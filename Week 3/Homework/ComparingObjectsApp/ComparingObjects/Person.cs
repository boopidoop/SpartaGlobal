namespace ComparingObjects;

public class Person : IEquatable<Person?>, IComparable<Person?>
{
    private string _firstName = "", _lastName = "";
    private int _age;
    public Person() { }
    public Person(string fName, string lName)
    {
        _firstName = fName;
        _lastName = lName;
    }

    public int Age
    {
        get { return _age; }
        set { if (value >= 0) _age = value; }
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Person);
    }

    public bool Equals(Person? other)
    {
        return other is not null &&
               _firstName == other._firstName &&
               _lastName == other._lastName &&
               _age == other._age &&
               Age == other.Age;
    }

    public string GetFullName()
    {
        return $"{_firstName} {_lastName}";
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_firstName, _lastName, _age, Age);
    }

    public static bool operator ==(Person? left, Person? right)
    {
        return EqualityComparer<Person>.Default.Equals(left, right);
    }

    public static bool operator !=(Person? left, Person? right)
    {
        return !(left == right);
    }

    public int CompareTo(Person? other)
    {
        if (other == null) return 1;
        if (this._firstName != other._firstName)
        {
            return this._firstName.CompareTo(other._firstName);
        }
        else if (this._lastName != other._lastName)
        {
            return this._lastName.CompareTo(other._lastName);
        }
        else
        {
            return this._age.CompareTo(other._age);
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()} [_firstName: {_firstName} \t_lastName: {_lastName} \t_age: {_age}]";
    }
}