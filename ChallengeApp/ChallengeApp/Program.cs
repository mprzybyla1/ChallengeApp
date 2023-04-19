
string name = "Ewa";
string sex = "Kobieta";
int age = 33;

if (sex == "Kobieta")
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (age >= 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
}
else if (age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (age >= 18)
{
    Console.WriteLine("Pełnoletni mężczyzna");
}