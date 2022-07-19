using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp;

public class Airplane : Vehicle
{
    private string _airline = "";

    public Airplane(int capacity) : base(capacity) { }

    public Airplane(int capacity, int speed, string airline) : base(capacity, speed) {
        _airline = airline;
    }

    public int Altitude { get; private set; }

    public void Ascend(int distance)
    {
        checked
        {
            Altitude += (Altitude + distance) > 12_800 || distance < 0
                ? throw new ArgumentException("Plane cannot legally fly above 12800 metres!")
                : distance < 0 ? throw new ArgumentException("Distance cannot be negative")
                : distance;
        }
    }

    public void Descend(int distance)
    {
        checked
        {
            Altitude -= (Altitude - distance) < 200
            ? throw new ArgumentException("Plane cannot legally fly lower than 200 metres unless landing!")
            : distance < 0 ? throw new ArgumentException("Distance cannot be negative")
            : distance;
        }
    }

    public string Move()
    {
        checked
        {
            Position += Speed;
            return $"Moving along at an altitude of {Altitude} metres.";
        }
    }

    public string Move(int times)
    {
        checked
        {
            Position += times < 0 ? throw new ArgumentException()
            : times == 1 ? Position = Position
            : Speed * times;
            return times == 1 ? Move() : $"Moving along {times} times at an altitude of {Altitude} metres.";
        }
    }

    public override string ToString()
    {
        return $"Thank you for flying {_airline}: {base.ToString()} capacity: {_capacity} " +
            $"passengers: {_numPassengers} speed: {Speed} position: {Position} altitude: {Altitude}.";
    }
}
