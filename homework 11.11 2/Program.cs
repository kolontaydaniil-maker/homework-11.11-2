//Задание 1
//interface ICalc
//{
//    int Less(int valueToCompare);
//    int Greater(int valueToCompare);
//}

//class Array : ICalc
//{
//    int[] numbers;

//    public Array(int[] numbers)
//    {
//        this.numbers = numbers;
//    }

//    public int Less(int valueToCompare)
//    {
//        int count = 0;

//        foreach (int number in numbers)
//        {
//            if (number < valueToCompare)
//                count++;
//        }

//        return count;
//    }

//    public int Greater(int valueToCompare)
//    {
//        int count = 0;

//        foreach (int number in numbers)
//        {
//            if (number > valueToCompare)
//                count++;
//        }

//        return count;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Array arr = new Array(new int[] { 1, 5, 8, 3, 10, 2 });

//        Console.WriteLine("Меньше: " + arr.Less(5));
//        Console.WriteLine("Больше: " + arr.Greater(5));
//    }
//}

//Задание 2
//interface IOutput2
//{
//    void ShowEven();
//    void ShowOdd();
//}

//class Array : IOutput2
//{
//    int[] numbers;

//    public Array(int[] numbers)
//    {
//        this.numbers = numbers;
//    }

//    public void ShowEven()
//    {
//        Console.WriteLine("Четные числа:");

//        foreach (int number in numbers)
//        {
//            if (number % 2 == 0)
//                Console.WriteLine(number);
//        }
//    }

//    public void ShowOdd()
//    {
//        Console.WriteLine("Нечетные числа:");

//        foreach (int number in numbers)
//        {
//            if (number % 2 != 0)
//                Console.WriteLine(number);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Array arr = new Array(new int[] { 1, 2, 3, 4, 5, 6 });

//        arr.ShowEven();
//        arr.ShowOdd();
//    }
//}

//Задание 3
//interface ICalc2
//{
//    int CountDistinct();
//    int EqualToValue(int valueToCompare);
//}

//class Array : ICalc2
//{
//    int[] numbers;

//    public Array(int[] numbers)
//    {
//        this.numbers = numbers;
//    }

//    public int CountDistinct()
//    {
//        int count = 0;

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            bool unique = true;

//            for (int j = 0; j < i; j++)
//            {
//                if (numbers[i] == numbers[j])
//                {
//                    unique = false;
//                    break;
//                }
//            }

//            if (unique)
//                count++;
//        }

//        return count;
//    }

//    public int EqualToValue(int valueToCompare)
//    {
//        int count = 0;

//        foreach (int number in numbers)
//        {
//            if (number == valueToCompare)
//                count++;
//        }

//        return count;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Array arr = new Array(new int[] { 1, 2, 2, 3, 4, 4, 5 });

//        Console.WriteLine("Количество уникальных значений: " + arr.CountDistinct());
//        Console.WriteLine("Количество одинаковых значений: " + arr.EqualToValue(2));
//    }
//}

//Задание 4
//interface IRemoteControl
//{
//    void TurnOn();
//    void TurnOff();
//    void SetChannel(int channel);
//}

//class Television : IRemoteControl
//{
//    public void TurnOn()
//    {
//        Console.WriteLine("Телевизор включен");
//    }

//    public void TurnOff()
//    {
//        Console.WriteLine("Телевизор выключен");
//    }

//    public void SetChannel(int channel)
//    {
//        Console.WriteLine("Канал телевизора: " + channel);
//    }
//}

//class Radio : IRemoteControl
//{
//    public void TurnOn()
//    {
//        Console.WriteLine("Радио включено");
//    }

//    public void TurnOff()
//    {
//        Console.WriteLine("Радио выключено");
//    }

//    public void SetChannel(int channel)
//    {
//        Console.WriteLine("Станция радио: " + channel);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Television tv = new Television();
//        Radio radio = new Radio();

//        tv.TurnOn();
//        tv.SetChannel(5);
//        tv.TurnOff();

//        radio.TurnOn();
//        radio.SetChannel(10);
//        radio.TurnOff();
//    }
//}

//Задание 5
//interface IValidator
//{
//    bool Validate();
//}

//class PasswordValidator : IValidator
//{
//    string password;

//    public PasswordValidator(string password)
//    {
//        this.password = password;
//    }

//    public bool Validate()
//    {
//        return password.Length >= 8;
//    }
//}

//class EmailValidator : IValidator
//{
//    string email;

//    public EmailValidator(string email)
//    {
//        this.email = email;
//    }

//    public bool Validate()
//    {
//        return email.Contains("@") && email.Contains(".");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        PasswordValidator password = new PasswordValidator("12345678");
//        EmailValidator email = new EmailValidator("test@gmail.com");

//        Console.WriteLine("Пароль корректный: " + password.Validate());
//        Console.WriteLine("Почта корректная: " + email.Validate());
//    }
//}