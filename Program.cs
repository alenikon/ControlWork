// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] array1 = null;
                Console.WriteLine("Введите любое предложение:");
                string stringNumber = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(stringNumber))
                    array1 = stringNumber.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                    string strElements = Console.ReadLine();

string[] LenSubString(int len, string str)

{

    string[] s = str.Split(' ');

    if (s.Length == 0)

    {

        string[] res = new string[0];

        return res;

    }

    else

    {

        string result = "";

        foreach (string item in s)

        {

            if (item.Length <= len)

            {

                result += item + " ";

            }

        }

        string[] resultArr = result.Split(' ');

        return resultArr;

    }

}

string[] array1 = null;
                Console.WriteLine("Введите любое предложение:");
                string stringNumber = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(stringNumber))
                    array1 = stringNumber.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                else continue;
                Console.Clear();

                string[] array2 = new string[array1.Length];
                for (int i = 0; i < array1.Length; i++)
                    if (array1[i].Length <= 3)
                        array2[i] = array1[i];

                Console.WriteLine($"Массив строк у которых длинна <=3: ");
                Console.WriteLine(string.Join(" ", array2));