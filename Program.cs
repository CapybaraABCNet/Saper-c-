using System;
using System.Threading; 

namespace HelloWorldApplication
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            string command;
            string numberOne;
            bool oneYroven = true;
            int chisloOne = 0;

            Console.WriteLine("Привет! Это игра сапёр! Какой режим выберешь (пиши цифру команды)?:");
            Console.WriteLine("1. Обычный");
            Console.WriteLine("2. Уровни");
            command = Console.ReadLine();

            if (command == "2")
            {
                Console.WriteLine("Запускаем...");
                Thread.Sleep(2000);
                Console.WriteLine("Уровень N1");
                Console.WriteLine("-----------------------");
                Console.WriteLine("|  3  |  5  |  6  | 8 |");
                Console.WriteLine("-----------------------");
                Console.WriteLine("|  2  |  4  |  7  | 9 |");
                Console.WriteLine("-----------------------");
                Console.WriteLine("|  1  |  0  | 10 | 11 |");
                Console.WriteLine("-----------------------");

                while (oneYroven)
                {
                    Console.WriteLine("Введите клетку, которую вы хотите открыть:");
                    numberOne = Console.ReadLine();

                    switch (numberOne)
                    {
                        case "1":
                            chisloOne += 1;
                            Console.WriteLine("Там оказалась бомба! Game over!");
                            oneYroven = false; 
                            break;
                        case "2":
                            
                            Console.WriteLine("Там не было бомбы.");
                            chisloOne += 1;
                            if (chisloOne == 9)
                            {
                                Console.WriteLine("Правильно! You win! Второй уровень");
                                oneYroven = false;
                                twoLL();
                            }
                            break;
                        case "3":
                            
                            Console.WriteLine("Там не было бомбы.");
                            chisloOne += 1;
                            if (chisloOne == 9)
                            {
                                Console.WriteLine("Правильно! You win! Второй уровень");
                                oneYroven = false;
                                twoLL();
                            }
                            break;
                        case "4":
                            Console.WriteLine("Там не было бомбы.");
                            chisloOne += 1;
                            if (chisloOne == 9)
                            {
                                Console.WriteLine("Правильно! You win! Второй уровень");
                                oneYroven = false;
                                twoLL();
                            }
                            break;
                        case "5":
                            Console.WriteLine("Там не было бомбы.");
                            chisloOne += 1;
                            if (chisloOne == 9)
                            {
                                Console.WriteLine("Правильно! You win! Второй уровень");
                                oneYroven = false;
                                twoLL();
                            }
                            break;
                        case "6":
                            Console.WriteLine("Там оказалась бомба! Game over!");
                            oneYroven = false; 
                            break;
                        case "7":
                            Console.WriteLine("Там не было бомбы.");
                            chisloOne += 1;
                            if (chisloOne == 9)
                            {
                                Console.WriteLine("Правильно! You win! Второй уровень");
                                oneYroven = false;
                                twoLL();
                            }
                            break;
                        case "8":
                            Console.WriteLine("Там не было бомбы.");
                            chisloOne += 1;
                            if (chisloOne == 9)
                            {
                                Console.WriteLine("Правильно! You win! Второй уровень");
                                oneYroven = false;
                                twoLL();
                            }
                            break;
                        case "9":
                            Console.WriteLine("Там не было бомбы.");
                            chisloOne += 1;
                            if (chisloOne == 9)
                            {
                                Console.WriteLine("Правильно! You win! Второй уровень");
                                oneYroven = false;
                                twoLL();
                            }
                            break;
                        case "10":
                            Console.WriteLine("Там не было бомбы.");
                            chisloOne += 1;
                            if (chisloOne == 9)
                            {
                                Console.WriteLine("Правильно! You win! Второй уровень");
                                oneYroven = false;
                                twoLL();
                            }
                            break;
                        case "11":
                            Console.WriteLine("Там оказалась бомба! Game over!");
                            oneYroven = false; 
                            break;
                        case "0":
                            Console.WriteLine("Там не было бомбы.");
                            chisloOne += 1;
                            if (chisloOne == 9)
                            {
                                Console.WriteLine("Правильно! You win! Второй уровень");
                                oneYroven = false;
                                twoLL();
                            }
                            break;
                        default:
                            Console.WriteLine("Вы кажется неправильно ввели команду, попробуйте ещё раз.");
                            break;
                    }
                }
            }
            else if (command == "1")
            {
                norm();
            }
            else
            {
                Console.WriteLine("Выберите корректный режим (1 или 2).");
            }
        }
        static void twoLL()
        {
            string numberTwo;
            bool twoYroven = true;
            int chisloTwo = 0;
            Console.WriteLine("Продолжаем");
            Thread.Sleep(2000);
            Console.WriteLine("--------------------------");
            Console.WriteLine("|  5  |  6  |  7   |  8  |");
            Console.WriteLine("--------------------------");
            Console.WriteLine("|  1  |  2  |  3   |  4  |");
            Console.WriteLine("--------------------------");
            while (twoYroven)
            {
                Console.WriteLine("Введите номер комманды");
                numberTwo = Console.ReadLine();
                switch (numberTwo)
                {
                    case "1":
                        Console.WriteLine("Там не было бомбы");
                        chisloTwo += 1;
                        if (chisloTwo == 6)
                        {
                            Console.WriteLine("Правильно! You win! Пока уровней нет, но в будующем будет больше");
                            twoYroven = false;
                            
                        }
                        break;
                    case "2":
                        Console.WriteLine("Там не было бомб");
                        chisloTwo += 1;
                        if (chisloTwo == 9)
                        {
                            Console.WriteLine("Правильно! You win! Пока уровней нет, но в будующем будет больше");
                            twoYroven = false;

                        }
                        break;
                    case "3":
                        Console.WriteLine("Это была бомба, Game Over!");
                        twoYroven = false;
                        break;
                    case "4":
                        Console.WriteLine("Там не было бомб");
                        chisloTwo += 1;
                        if (chisloTwo == 6)
                        {
                            Console.WriteLine("Правильно! You win! Пока уровней нет, но в будующем будет больше");
                            twoYroven = false;

                        }
                        break;
                    case "5":
                        Console.WriteLine("Там не было бомб");
                        chisloTwo += 1;
                        if (chisloTwo == 6)
                        {
                            Console.WriteLine("Правильно! You win! Пока уровней нет, но в будующем будет больше");
                            twoYroven = false;

                        }
                        break;
                    case "6":
                        Console.WriteLine("Там не было бомб");
                        chisloTwo += 1;
                        if (chisloTwo == 6)
                        {
                            Console.WriteLine("Правильно! You win! Пока уровней нет, но в будующем будет больше");
                            twoYroven = false;

                        }
                        break;
                    case "7":
                        Console.WriteLine("Это была бомба, Game Over!");
                        twoYroven = false;
                        break;
                    case "8":
                        Console.WriteLine("Там не было бомб");
                        chisloTwo += 1;
                        if (chisloTwo == 6)
                        {
                            Console.WriteLine("Правильно! You win! Пока уровней нет, но в будующем будет больше");
                            twoYroven = false;

                        }
                        break;
                    
                }
            }
            
        }
        static void norm()
        {
            string numberThree;
            bool threeYroven = true;
            int chisloThree = 0;
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int six = 0;
            int seven = 0;
            int eight = 0;
            int nine = 0;
            int ten = 0;
            int eleven = 0;
            int non = 0;
            
            var rand = new Random();
            byte[] bytes = new byte[5];
            int chislo1 = rand.Next(0, 3);
            int chislo2 = rand.Next(4, 7);
            int chislo3 = rand.Next(8, 11);

            //Console.WriteLine(chislo1);
            //Console.WriteLine(chislo2);
            //Console.WriteLine(chislo3);
            Console.WriteLine("---------------------------");
            Console.WriteLine("|  8  |  9  |  10  |  11  |");
            Console.WriteLine("---------------------------");
            Console.WriteLine("|  4  |  5  |  6   |   7  |");
            Console.WriteLine("---------------------------");
            Console.WriteLine("|  0  |  1  |  2   |   3  |");
            Console.WriteLine("---------------------------");

            while (threeYroven) {
                

                Console.WriteLine("Введите номер комманды");
                numberThree = Console.ReadLine();
                if (int.TryParse(numberThree, out int userCommand))
                {
                    if (userCommand == chislo1) { 
                        Console.WriteLine("Там оказалась бомба! Game over!");
                        threeYroven = false;
                    } else if (userCommand == chislo2)
                    {
                        Console.WriteLine("Там оказалась бомба! Game over!");
                        threeYroven = false;
                    } else if (userCommand == chislo3)
                    {
                        Console.WriteLine("Там оказалась бомба! Game over!");
                        threeYroven = false;
                    }  else if (userCommand > 11)
                    {
                        Console.WriteLine("Ошибка, Введите то число которое в пределах 0 и 11");
                    }
                    


                    else
                    {
                        Console.WriteLine("там нету бомбы");
                        chisloThree += 1;
                        if (userCommand == 1)
                        {
                            one++;
                            if (one == 2)
                            {
                                Console.WriteLine("Ошибка, нельзя писать один ответ несколько раз");
                                threeYroven = false;
                            }
                        }
                        else if (userCommand == 2)
                        {
                            two++;
                            if (two == 2)
                            {
                                Console.WriteLine("Ошибка, нельзя писать один ответ несколько раз");
                                threeYroven = false;
                            }
                        }
                        else if (userCommand == 3)
                        {
                            three++;
                            if (three == 2)
                            {
                                Console.WriteLine("Ошибка, нельзя писать один ответ несколько раз");
                                threeYroven = false;
                            }
                        }
                        else if (userCommand == 4)
                        {
                            four++;
                            if (four == 2)
                            {
                                Console.WriteLine("Ошибка, нельзя писать один ответ несколько раз");
                                threeYroven = false;
                            }
                        }
                        else if (userCommand == 5)
                        {
                            five++;
                            if (five == 2)
                            {
                                Console.WriteLine("Ошибка, нельзя писать один ответ несколько раз");
                                threeYroven = false;
                            }
                        }
                        else if (userCommand == 6)
                        {
                            six++;
                            if (six == 2)
                            {
                                Console.WriteLine("Ошибка, нельзя писать один ответ несколько раз");
                                threeYroven = false;
                            }
                        }
                        else if (userCommand == 7)
                        {
                            seven++;
                            if (seven == 2)
                            {
                                Console.WriteLine("Ошибка, нельзя писать один ответ несколько раз");
                                threeYroven = false;
                            }

                        }
                        else if (userCommand == 8)
                        {
                            eight++;
                            if (eight == 2)
                            {
                                Console.WriteLine("Ошибка, нельзя писать один ответ несколько раз");
                                threeYroven = false;
                            }

                        }
                        else if (userCommand == 9)
                        {
                            nine++;
                            if (nine == 2)
                            {
                                Console.WriteLine("Ошибка, нельзя писать один ответ несколько раз");
                                threeYroven = false;
                            }
                        }
                        else if (userCommand == 10)
                        {
                            ten++;
                            if (ten == 2)
                            {
                                Console.WriteLine("Ошибка, нельзя писать один ответ несколько раз");
                                threeYroven = false;
                            }

                        }
                        else if (userCommand == 11)
                        {
                            eleven++;
                            if (eleven == 2)
                            {
                                Console.WriteLine("Ошибка, нельзя писать один ответ несколько раз");
                                threeYroven = false;
                            }

                        }
                        else if (userCommand == 0)
                        {
                            non++;
                            if (non == 2)
                            {
                                Console.WriteLine("Ошибка, нельзя писать один ответ несколько раз");
                                threeYroven = false;
                            }

                        }
                        if (chisloThree == 9)
                        {
                            Console.WriteLine("Правильно! You win!");
                            threeYroven = false;

                        }

                    }

                }
            }

        }
    }
}
