Console.WriteLine("Ведите пятизначное число: ");
string numbers = Console.ReadLine();

string Shifter(string number)
{
    char[] numberArray = number.ToCharArray();
    Array.Reverse(numberArray);
    return new string(numberArray);
}

bool LetterInNumbers(string let)
{
    int n = let.Length;
    bool yes = true;
    if (n == 5)
    {
        for (int i = 0; i < n; i++)
        {
            // if (Char.IsLetter(let[i]) == true || Char.IsSymbol(let[i]) == true)
            if (Char.IsDigit(let[i]) == false)
            {
                yes = false;
                return yes;
            }
        }
        return yes;
    }
    else
    {
        yes = false;
        return yes;
    }
}

bool letter = LetterInNumbers(numbers);
string shifter = Shifter(numbers);

if (letter == true)
{
    if (shifter == numbers) 
        Console.WriteLine($"{numbers} является палиндромом? -> Да!");
    else Console.WriteLine($"{numbers} является палиндромом? -> Нет!");
}
else Console.WriteLine($"{numbers} -> Некорректный ввод!" +
    "\nНеобходимо ввести пятизначное число в диапазоне от 10000 до 99999" +
    "\nНапример: 12321 ");