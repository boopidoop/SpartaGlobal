using System.Text;
using System.Collections;

namespace ComparingObjects;

public class Program
{
    public static void Main(string[] args)
    {
        var dan = new Person("Daniel", "Summerside") { Age = 25 };
        var nish = new Person("Nishant", "Mandal") { Age = 32 };
        var jon = new Person("Jonathan", "Crofts") { Age = 42 };
        var dave = new Person("David", "Joyce") { Age = 45 };

        #region Comparisons
        Console.WriteLine(nish == dan ? $"{nish.GetFullName()} is Equal to {dan.GetFullName()}" : $"{nish.GetFullName()} is Not Equal to {dan.GetFullName()}");
        Console.WriteLine(nish == dan ? $"Person {nish.GetHashCode()} is Equal to Person {jon.GetHashCode()}" : $"Person {nish.GetHashCode()} is Not Equal to Person {jon.GetHashCode()}");

        var bob = new Person("Bob", "Builder") { Age = 25 };
        var people = new List<Person>()
        {
            new Person("Cath", "Cookson"),
            new Person("Bob", "Builder") {Age = 25 },
            new Person("Dan", "Dare"),
            new Person("Amy", "Andrews") {Age = 32 },
        };

        Random rand = new Random();

        for (int i = 0; i < rand.Next(5, 10); i++)
            people.Add(new Person(RandomNameGenerator(2, 10), RandomNameGenerator(5, 15)) { Age = rand.Next(0, 100) });

        if (people.Contains(bob))
            Console.WriteLine("Bob is in the list\n");

        List<Person> people2 = new List<Person> {
            new Person("Kai", "Chan") { Age = 244 },
            new Person("jon", "Woolycroft") { Age = 39 },
            new Person("Daniel", "Summerside") { Age = 25 }
        };

        people.AddRange(people2);

        Console.WriteLine(string.Join("\n", people) + "\n------------\n");
        people.Sort();
        Console.WriteLine(string.Join("\n", people) + "\n------------\n");
        #endregion

        #region Exercise
        List<int> list = new List<int> { 5, 4, 3, 9, 0 };
        list.Add(8);
        list.Sort();
        list.RemoveAt(2);
        list.RemoveAt(1);
        list.Insert(2, 1);
        list.Reverse();
        list.Remove(9);
        Console.WriteLine(string.Join(", ", list));
        #endregion

        #region LinkedLists
        LinkedList<Person> linkedList = new LinkedList<Person>();

        linkedList.AddFirst(jon);
        linkedList.AddLast(dan);

        foreach (var item in linkedList)
            Console.WriteLine(item);
        Console.WriteLine(linkedList.Find(jon));
        #endregion

        #region Queues
        Queue<Person> myQueue = new Queue<Person>();

        myQueue.Enqueue(dan);
        myQueue.Enqueue(nish);
        myQueue.Enqueue(jon);
        myQueue.Enqueue(dave);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nQueue");
        Console.ResetColor();

        foreach (Person person in myQueue)
            Console.WriteLine(person);

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\n\tRemoving first element from queue");
        Console.ResetColor();

        var serve = myQueue.Dequeue();
        foreach (Person person in myQueue)
            Console.WriteLine("\t" + person);
        #endregion

        #region Stack
        Stack<Person> myStack = new Stack<Person>();

        myStack.Push(dan);
        myStack.Push(nish);
        myStack.Push(jon);
        myStack.Push(dave);

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nStack");
        Console.ResetColor();

        foreach (Person person in myStack)
            Console.WriteLine(person);

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\n\tRemoving first element from queue");
        Console.ResetColor();

        myStack.Pop();
        foreach (Person person in myStack)
            Console.WriteLine("\t" + person);
        #endregion

        #region HashSets
        var myHashSet = new HashSet<Person>() { dan, nish, jon, dave, dave, dave, dave };

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nHash Set");
        Console.ResetColor();

        foreach (var entry in myHashSet)
            Console.WriteLine(entry);

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\n\tAdding 1000 random numbers between 0 and 9");
        Console.ResetColor();

        var numberHashSet = new HashSet<int>();
        for (int i = 0; i < 1000; i++)
            numberHashSet.Add(rand.Next(0, 10));

        Console.Write("\t");
        foreach (var entry in numberHashSet)
            Console.Write(entry + " ");

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\n\n\tIntersection Test");
        Console.ResetColor();

        myHashSet.IntersectWith(new HashSet<Person>() {
            new Person("Daniel", "Summerside") { Age = 25 }, 
            new Person("Derek", "Winterbottom") { Age = 25 },
            nish
        });

        foreach (var entry in myHashSet)
            Console.WriteLine("\t" + entry);
        #endregion

        #region Dictionary
        var myDict = new Dictionary<string, Person>()
        {
            {"Dan", dan },
            {"Nish", nish },
            {"Jon", jon },
            {"Dave", dave }
        };

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nDictionaries");
        Console.ResetColor();

        Console.WriteLine($"Information for Dan: {myDict["Dan"].GetFullName()}");

        string input = "The cat in the hat comes back";
        string inputTrimLower = input.Trim().ToLower();

        var countDict = new Dictionary<char, int>();

        foreach (char c in inputTrimLower)
            if (countDict.ContainsKey(c)) countDict[c]++; else countDict.Add(c, 1);
        Console.Write($"\n\tDictionary Problem\n\t'{input}' contains: \n\t");

        foreach (var entry in countDict.OrderByDescending(x => x.Value))
            Console.Write(entry + " ");
        #endregion
    }

    public static string RandomNameGenerator(int sizeMin, int sizeMax)
    {
        int uppercase = 65, lowercase = 97;
        StringBuilder name = new StringBuilder();
        Random rand = new Random();

        for (int i = 0; i < rand.Next(sizeMin, sizeMax); i++)
            if (i == 0)
                name.Append((char)rand.Next(uppercase, uppercase + 26));
            else
                name.Append((char)rand.Next(lowercase, lowercase + 26));

        return name.ToString();
    }
}