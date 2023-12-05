using System;
class MyProgram
{
    static void Main()
    {        
        char value = 'A';      
        char[] array = new char[10];
        for (int i = 0; i < array.Length; i++)
        {
            switch (value)
            {               
                case 'A':
                    value++;
                    break;
                case 'E':
                    value++;
                    break;
                case 'I':
                    value++;
                    break;
            }
            array[i] = value;
            value++;
        }
        for (int j = 0; j < array.Length; j++)
        {
            Console.WriteLine("{0} = {1}", j, array[j]);
        }
        Console.ReadKey();

    }
}