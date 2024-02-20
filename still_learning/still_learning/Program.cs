// See https://aka.ms/new-console-template for more information

using still_learning;

dog doggy = new dog();
doggy.gopark();
doggy.bark();

places doggy2 = new dog();

doggy2.gocity();
doggy2.gohome();

List<list_class> lst = new List<list_class> ();

Console.WriteLine("How many dog data will you enter :");
int sayi = int.Parse(Console.ReadLine());


for (int i = 0; i < sayi; i++)
{

    Console.WriteLine("Please enter your dogs name: ");
    string input_name = Console.ReadLine();

    Console.WriteLine("Please enter your dogs age: ");
    int input_age = int.Parse(Console.ReadLine());

    lst.Add(new list_class { dog_name = input_name, dog_age = input_age });

}

Console.WriteLine("If you'd like too see the dogs list, please press 1");

int number = 1;
bool success = int.TryParse(Console.ReadLine(), out number);

if(success)
{
    foreach (list_class c in lst)
    {
        Console.WriteLine($"Dogs name: {c.dog_name}\nDogs age: {c.dog_age}");
        doggy.bark();
    }
}
else
{
    Console.WriteLine("Bye!");
}

