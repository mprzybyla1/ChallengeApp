int number = 4566; 
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in letters)
{
    if(letter == '0')
    {
        counter0++;
    }
    else if(letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }
}

Console.WriteLine("0 => " + counter0);
Console.WriteLine("1 => " + counter1);
Console.WriteLine("2 => " + counter2);
Console.WriteLine("3 => " + counter3);
Console.WriteLine("4 => " + counter4);
Console.WriteLine("5 => " + counter5);
Console.WriteLine("6 => " + counter6);
Console.WriteLine("7 => " + counter7);
Console.WriteLine("8 => " + counter8);
Console.WriteLine("9 => " + counter9);

int number1 = 1234;
string number1AsString = number1.ToString();
char[] letters1 = number1AsString.ToArray();

int countera = 0;
int counterb = 0;
int counterc = 0;
int counterd = 0;
int countere = 0;
int counterf = 0;
int counterg = 0;
int counterh = 0;
int counteri = 0;
int counterj = 0;

for (int counter = 0; counter < letters1.Length; counter++)
{
    if (letters1[counter] == '0')
    {
        countera++;
    }
    if (letters1[counter] == '1')
    {
        counterb++;
    }
    if (letters1[counter] == '2')
    {
        counterc++;
    }
    if (letters1[counter] == '3')
    {
        counterd++;
    }
    if (letters1[counter] == '4')
    {
        countere++;
    }
    if (letters1[counter] == '5')
    {
        counterf++;
    }
    if (letters1[counter] == '6')
    {
        counterg++;
    }
    if (letters1[counter] == '7')
    {
        counterh++;
    }
    if (letters1[counter] == '8')
    {
        counteri++;
    }
    if (letters1[counter] == '9')
    {
        counterj++;
    }
}

Console.WriteLine("0 => " + countera);
Console.WriteLine("1 => " + counterb);
Console.WriteLine("2 => " + counterc);
Console.WriteLine("3 => " + counterd);
Console.WriteLine("4 => " + countere);
Console.WriteLine("5 => " + counterf);
Console.WriteLine("6 => " + counterg);
Console.WriteLine("7 => " + counterh);
Console.WriteLine("8 => " + counteri);
Console.WriteLine("9 => " + counterj);