using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp;

public class Vehicle
{
    protected int _capacity = 5;
    protected int _numPassengers;

    public Vehicle() { }
    public Vehicle(int capacity, int speed = 10)
    {
        _capacity = capacity < 0 ? throw new ArgumentException("Capacity can't be less than 0") : capacity;
        Speed = speed;
    }

    public int NumPassengers
    {
        get { return _numPassengers; } 
        set { _numPassengers = value > _capacity || value < 0 ? throw new ArgumentException($"Number of passengers cannot be less than 0 or greater than {_capacity}") : value; }
    }

    public int Position { get; protected set; }
    public int Speed { get; init; } = 10;

    public string Move()
    {
        Position += Speed;
        return "Moving along";
    }

    public string Move(int times)
    {
        Position += times < 0 ? throw new ArgumentException("Cannot move a negative number of times") : Speed * times;
        return times == 1 ? Move() : $"Moving along {times} times";
    }
}
