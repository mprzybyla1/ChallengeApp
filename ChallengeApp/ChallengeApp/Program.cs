// 1. Stwórz klasę Employee, w której przechowasz imię, nazwisko, wiek 
// oraz punkty pracownika w postaci liczb całkowitych.
// 2. Stwórz 3 pracowników i każdemu przydziel po 5 ocen z zakresu od 1 do 10.
// 3. Napisz program, który wyszuka pracownika z najwyższą liczbą ocen, 
// a następnie wyświetli jego dane oraz wyniki. 


using ChallengeApp;

Employee employee1 = new Employee("Adam", "Nowak", 25);            //20
Employee employee2 = new Employee("Monika", "Kowalska", 20);       //25
Employee employee3 = new Employee("Kasia", "Mickiewicz", 35);      //15

employee1.AddScore(-29);
employee1.AddScore(2);
employee1.AddScore(4);
employee1.AddScore(6);
employee1.AddScore(8);

employee2.AddScore(-27);
employee2.AddScore(3);
employee2.AddScore(5);
employee2.AddScore(7);
employee2.AddScore(9);

employee3.AddScore(-18);
employee3.AddScore(2);
employee3.AddScore(3);
employee3.AddScore(4);
employee3.AddScore(5);


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -100;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if(employee1.Result > maxResult)
    {
        employeeWithMaxResult = employee1;
        maxResult = employee1.Result;
    }
    else if (employee2.Result > maxResult)
    {
        employeeWithMaxResult = employee2;
        maxResult = employee2.Result;
    }
    else if (employee3.Result > maxResult)
    {
        employeeWithMaxResult = employee3;
        maxResult = employee3.Result;
    }
}

Console.WriteLine("Pracownik z najwyższą liczbą ocen: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname);
Console.WriteLine("Wiek: " + employeeWithMaxResult.Age + " " + "lat");
Console.WriteLine("Wynik: " + employeeWithMaxResult.Result);






// User (typ) user1 (użytkownik1) = new User();
// modyfikator dostępu: public, private.
// konstruktor: dodatkowe miejsce, które jest wywoływane w momencie gdy tworzony jest dany obiekt. 
// W konstruktorze możemy wpisać dane prywatne danych użytkowników danej klasy. 

// nazwa klasy: User
// pola: parametry opisujące nasz obiekt.
// metoda: fragment kodu, który można sobie uruchomić wewnątrz lub na zewnątrz klasy,
// metody mogą być publiczne lub prywatne.
