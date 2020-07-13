using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherInfo;

namespace Lesson7.DZ
{
    class Program
    {
        static void Main(string[] args)
        {

            Weather weth = new Weather();

        InputDate:

            Console.WriteLine("Введите дату:");
            string inputDate = Console.ReadLine();
            int date = int.Parse(inputDate);

            weth.Date += date;

            if (weth.Date > 31)
            {
                Console.Clear();
                Console.WriteLine(weth.Date + "такой даты не существует, введите дату ещё раз!");
                Console.ReadKey();
                Console.Clear();
                goto InputDate;
            }
            else if (weth.Date <= 0)
            {
                Console.Clear();
                Console.WriteLine(weth.Date + " такой даты не существует, введите дату ещё раз!");
                Console.ReadKey();
                Console.Clear();
                goto InputDate;
            }

            Console.Clear();

            Console.WriteLine("Введите минимальную температуру:");
            string inputMinT = Console.ReadLine();
            float minT = float.Parse(inputMinT.Replace(".", ","));

            weth.min_Temperature += minT;

            Console.Clear();

            Console.WriteLine("Введите максимальную температуру:");
            string inputMaxT = Console.ReadLine();
            float maxT = float.Parse(inputMaxT.Replace(".", ","));

            weth.max_Temperature += maxT;

            Console.Clear();

            Console.WriteLine("Обачность ( 1 - ясно, 2 - малооблачно, 3 - облачно, 4 - грозовые тучи):");
            string inputOvercast = Console.ReadLine();
            int Overcast = int.Parse(inputOvercast);

            if (Overcast == 1)
            {
                weth.Overcast = (Overcast)1;
            }
            if (Overcast == 2)
            {
                weth.Overcast = (Overcast)2;
            }
            if (Overcast == 3)
            {
                weth.Overcast = (Overcast)3;
            }
            if (Overcast == 4)
            {
                weth.Overcast = (Overcast)4;
            }

            Console.Clear();

            Console.WriteLine("Осадки ( 1 - дождь, 2 - снег, 3 - дождь со снегом, 4 - град, 5 - снежная крупа, 6 - роса, 7 - иней, 8 - изморозь, 9 - гололед, 10 - ледяные иглы ):");
            string inputPrecipitation = Console.ReadLine();
            int Precipitation = int.Parse(inputPrecipitation);

            if (Precipitation == 1)
            {
                weth.Precipitation = (Precipitation)1;
            }
            if (Precipitation == 2)
            {
                weth.Precipitation = (Precipitation)2;
            }
            if (Precipitation == 3)
            {
                weth.Precipitation = (Precipitation)3;
            }
            if (Precipitation == 4)
            {
                weth.Precipitation = (Precipitation)4;
            }
            if (Precipitation == 5)
            {
                weth.Precipitation = (Precipitation)5;
            }
            if (Precipitation == 6)
            {
                weth.Precipitation = (Precipitation)6;
            }
            if (Precipitation == 7)
            {
                weth.Precipitation = (Precipitation)7;
            }
            if (Precipitation == 8)
            {
                weth.Precipitation = (Precipitation)8;
            }
            if (Precipitation == 9)
            {
                weth.Precipitation = (Precipitation)9;
            }
            if (Precipitation == 10)
            {
                weth.Precipitation = (Precipitation)10;
            }

        Console.Clear();

            Console.WriteLine("Влажность:");
            string inputHumidity = Console.ReadLine();
            float Humidity = float.Parse(inputHumidity.Replace("." , ","));

            weth.Humidity += Humidity;

        Console.Clear();

            Console.WriteLine("Сила ветра:");
            string inputWP = Console.ReadLine();
            float WidePower = float.Parse(inputWP.Replace(".", ","));

            weth.Wide_power += WidePower;

        Console.Clear();

            Console.WriteLine("Направление ветра ( 1 - Север, 2 - Северо-восток, 3 - Восток, 4 - Юго-восток, 5 - Юг, 6 - Юго-запад, 7 - Запад, 8 - Северо-запад):");
            string inputDOTW = Console.ReadLine();
            int DOTW = int.Parse(inputDOTW);
            
            if (DOTW == 1)
            {
                weth.Direction_of_the_wind = (Direction_of_the_wind)1;
            }
            if (DOTW == 2)
            {
                weth.Direction_of_the_wind = (Direction_of_the_wind)2;
            }
            if (DOTW == 3)
            {
                weth.Direction_of_the_wind = (Direction_of_the_wind)3;
            }
            if (DOTW == 4)
            {
                weth.Direction_of_the_wind = (Direction_of_the_wind)4;
            }
            if (DOTW == 5)
            {
                weth.Direction_of_the_wind = (Direction_of_the_wind)5;
            }
            if (DOTW == 6)
            {
                weth.Direction_of_the_wind = (Direction_of_the_wind)6;
            }
            if (DOTW == 7)
            {
                weth.Direction_of_the_wind = (Direction_of_the_wind)7;
            }
            if (DOTW == 8)
            {
                weth.Direction_of_the_wind = (Direction_of_the_wind)8;
            }

            Console.Clear();

            Console.WriteLine("Фаза луны ( 1 - Новолуние, 2 - Растущая, 3 - Полнолуние, 4 - Убывающая):");
            string inputMP = Console.ReadLine();
            int MP = int.Parse(inputMP);
            
            if (MP == 1)
            {
                weth.Moon_phase = (Moon_phase)1;
            }
            if (MP == 2)
            {
                weth.Moon_phase = (Moon_phase)2;
            }
            if (MP == 3)
            {
                weth.Moon_phase = (Moon_phase)3;
            }
            if (MP == 4)
            {
                weth.Moon_phase = (Moon_phase)4;
            }
            if (MP == 5)
            {
                weth.Moon_phase = (Moon_phase)5;
            }
            if (MP == 6)
            {
                weth.Moon_phase = (Moon_phase)6;
            }
            if (MP == 7)
            {
                weth.Moon_phase = (Moon_phase)7;
            }
            if (MP == 8)
            {
                weth.Moon_phase = (Moon_phase)8;
            }
            Console.Clear();
            Console.WriteLine("Дата = " + weth.Date);
            Console.WriteLine("Миниамальная температура = " + weth.min_Temperature);
            Console.WriteLine("Максимальная температура = " + weth.max_Temperature);
            Console.WriteLine("Облачность = " + weth.Overcast);
            Console.WriteLine("Осадки = " + weth.Precipitation);
            Console.WriteLine("Влажность = " + weth.Humidity);
            Console.WriteLine("Сила ветра = " + weth.Wide_power);
            Console.WriteLine("Направление ветра = " + weth.Direction_of_the_wind);
            Console.WriteLine("Фаза луны = " + weth.Moon_phase);
        }
    }
}

