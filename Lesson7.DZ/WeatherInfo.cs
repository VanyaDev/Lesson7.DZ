using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherInfo
{
    public enum Moon_phase : byte
    {
      Новолуние = 1,
      Растущая = 2,
      Полнолуние = 3,
      Убывающая = 4,
    }
    public enum Direction_of_the_wind : byte
    {
       Север = 1,
       Северо_восток = 2,
       Восток = 3,
       Юго_восток = 4,
       Юг = 5,
       Юго_запад = 6,
       Запад = 7,
       Северо_запад = 8,
    }
    public enum Overcast : byte
    {
        Ясно = 1, 
        Малооблочно = 2, 
        Облочно = 3,
        Грозовые_тучи = 4,
    }
    public enum Precipitation : byte
    {
        Дождь = 1,
        Снег = 2,
        Дождь_со_снегом = 3,
        Град = 4,
        Снежная_крупа = 5,
        Роса = 6,
        Иней = 7,
        Изморозь = 8,
        Гололед = 9, 
        Ледяные_иглы = 10,
    }
    class Weather
    {
        public int Date { get; set; } // Дата
        public float min_Temperature { get; set; } // Минимальная температура
        public float max_Temperature { get; set; } // Максимальная температура
        public Overcast Overcast { get; set; } // Облачность
        public Precipitation Precipitation { get; set; } // Осадки
        public float Humidity { get; set; } // Влажность
        public float Wide_power { get; set; } // Сила ветра
        public Direction_of_the_wind Direction_of_the_wind { get; set; } // Направление ветра
        public Moon_phase Moon_phase { get; set; } // Фаза луны
    }
}
