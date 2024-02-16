using System;
using HomeWork_Makarov_Ivan_number_3;
using HomeWork_Makarov_Ivan_number_3._1;

class program
{
    static void Main(string[] args)
    {
        bool personGet;
        IBaseArray[] arrays = new IBaseArray[3];
        Console.WriteLine("Вы введёте массив с клавиатуры?:  да/нет");
        personGet = personChoose();
        static bool personChoose()
        {
            bool personschoose = false;
            bool correct_or_incorrect_answer_is_incorrect = true;
            string input;
            while (correct_or_incorrect_answer_is_incorrect)
            {
                input = Console.ReadLine();
                if (input == "да")
                {
                    personschoose = true;
                    correct_or_incorrect_answer_is_incorrect = false;
                }
                else if (input == "нет")
                {
                    personschoose = false;
                    correct_or_incorrect_answer_is_incorrect = false;
                }
                else
                {
                    Console.WriteLine("Ответ некорректен, ответьте по-другому");
                }
            }
            return personschoose;
        }
        arrays[0] = new OneDimensionalArray(personGet);
        arrays[1] = new TwoDimensionalArray(personGet);
        arrays[2] = new SteppedArray(personGet);
        for (int i = 0; i < arrays.Length; i++)
        {
            IBaseArray array = arrays[i];
            Console.WriteLine("Напечатанный массив: ");
            array.Print();
            Console.WriteLine("Среднее значение элементов массива: ");
            Console.WriteLine(array.GetAverage());

        }
        IPrinter[] days = new IPrinter[4];
        days[0] = new Week();
        days[1] = new OneDimensionalArray(false);
        days[2] = new TwoDimensionalArray(false);
        days[3] = new SteppedArray(false);
        for (int i = 0; i < days.Length; i++)
        {
            days[i].Print();
            
        }
        
        
        Console.ReadKey();

    }
}