using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int choice; 
            
            
          
            do
            {
            Console.WriteLine("Выберете программу которую хотите запустить \n1.Угадай число \n2.Таблица умножения \n3.Вывод делителй числа \n4.Выход");
            input = Console.ReadLine();
            choice = Convert.ToInt32(input);
                 switch (choice)
                {
                    case 1:
                        Random random = new Random();
                        int rnd = random.Next(1, 10);
                        Console.WriteLine("угадай число от 1 до 10, для выхода напишите 11");
                        while (choice != rnd || choice == 11)  {
                            input = Console.ReadLine();
                            choice = Convert.ToInt32(input);
                            switch (choice > rnd) {
                                case true: Console.WriteLine("Бери чило меньше");
                                    break;
                                case false: Console.WriteLine("Бери число больше");
                                    break;          
                            }
                            Console.WriteLine("Ты победил");
                            break;
                        }
                        break;
                    case 2:
                        int[,] table= new int[10, 10];
                        for (int i = 0; i < 10; i = i + 1) {
                            for (int a = 0; a < 10; a = a + 1) { 
                            
                            table[a, i] = (i+1)*(a+1);

                            }
                        
                        }
                        for (int i = 0; i < table.GetLength(0); i = i + 1)
                        {
                            for (int a = 0; a < table.GetLength(0); a = a + 1)
                            {

                                Console.Write(table[a, i] + "");

                            }
                            Console.WriteLine();    

                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите число");
                        input = Console.ReadLine();
                        choice = Convert.ToInt32(input);
                        for (int i=1; i <= choice; i++) 
                        { 
                            switch (choice % i == 0) {

                                case true:
                                    Console.WriteLine(i);
                                    break;
                                case false:
                                    break;
                            
                            }
                        
                        }
                        break; 
                }


            } while (choice != 4);


        }
    }
}