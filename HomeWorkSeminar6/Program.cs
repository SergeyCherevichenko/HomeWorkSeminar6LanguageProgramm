namespace HomeWorkSeminar6;



class Program
{
    static void Main(string[] args)
    {
        void task41()
        {
            // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            //0, 7, 8, -2, -2 -> 2
            //-1, -7, 567, 89, 223-> 3

            int numberM = MyLib.Input("Введите количество чисел, которое вы будете вводить: ");
            int count = 0;
            while (numberM > 0)
            {
                int userNumber = MyLib.Input("Введите целое число: ");
                if (userNumber > 0) count++;
                numberM--;
            }
            Console.WriteLine("Вы ввели чисел больше 0 - " + count);


        }

        void task43()
        {
            // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
            //y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
            // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

            Console.WriteLine("Найти точку пересечения двух прямых, заданных уравнениями  y = k1 * x + b1, y = k2 * x + b2; ");
            int b1 = MyLib.Input("Введите значение b1: ");
            int k1 = MyLib.Input("Введите значение k1: ");
            int b2 = MyLib.Input("Введите значение b2: ");
            int k2 = MyLib.Input("Введите значение k2: ");


            double x = (double)(b1 - b2) / (k2 - k1);
            Console.WriteLine(x);
            double y = k1 * x + b1;
            Console.WriteLine($"Точка пересечения ваших прямых имеет координаты ({x}; {y})");


        }

        
        int task = MyLib.Input("Введите номер задачи 41 или 43: ");
        switch (task)
        {
            case 41: task41(); break;
            case 43: task43(); break;
            default: Console.WriteLine("Задачи с таким номер не существует");break;
        }
    }
}
