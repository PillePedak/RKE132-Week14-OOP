Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good girl");

Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neigbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad boy");

while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();

class Dog
{
    private string _name; //field
    private int _levelOfHappiness = 0;

    //constructor
    public Dog(string name) //name - lets the user name the dog
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    //getter
    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHapiness
    {
        get { return _levelOfHappiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }

}