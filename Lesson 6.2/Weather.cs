using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._2
{
    public class Weather
    {


        public Region WeatherRegion { get; set; }
        public DateTime Date { get; set; }
        public int Temperature { get; set; }
        public string Precipitation { get; set; }


        public Weather()
        {

        }

        public Weather(Region weather_region, DateTime date, int temperature, string precipitation)
        {
            WeatherRegion = weather_region;
            Date = date;
            Temperature = temperature;
            Precipitation = precipitation;

        }


        public override string ToString()
        {
            return ($"\n ______Погода______ \n Регион: {WeatherRegion.Name}\nДата : {Date.ToLongDateString()}\nТемпература : {Temperature} градусов\nОсадки : {Precipitation}");
        }
        //Значения осадков для создания погоды
        private string[] precipitation = new string[5] { "Снег", "Дождь", "Туман", "Солнечно", "Облачно" };
        //Создание погода за последние семь дней
        private void WeatherLastSevenDays(Weather info)
        {
            Random rand = new();
            info.Date = info.Date.AddDays(-1);
            info.Temperature = rand.Next(-10, 10);
            info.Precipitation = precipitation[rand.Next(0, 4)];

        }

        //Сведения о погоде в заданном регионе  
        public static void WeatherInPresentRegion(List<Weather> info)
        {
            Console.Write("Введите заданый регион : ");
            string present_region = Console.ReadLine();
            
            foreach( Weather box in info)
                if (box.WeatherRegion.Name == present_region)
                    Console.WriteLine(box.ToString());//Вывод погоды

        }
        //Вывести даты, когда в заданном регионе шел снег и температура была ниже заданной отрицательной.
        public static void WeatherRegionDate(List<Weather> info)
        {
            Console.Write("Введите регион : ");
            string present_region = Console.ReadLine();
            Console.Write("Введите температуру : ");
            int present_temperature = Convert.ToInt32(Console.ReadLine());

            foreach (Weather box in info)
            {
                if (box.WeatherRegion.Name == present_region && box.Precipitation == "Снег" &&box.Temperature < present_temperature)
                {
                    Console.Write($" { box.Date.ToLongDateString()} - шел снег и тепература была ниже заданой ");

                }
            }

        }
        //Вывести информацию о погоде за прошедшую неделю в регионах, жители которых общаются на заданном языке.
        public void WeatherInRegionLanguage(List<Weather> info)
        {
            Console.Write("Введите язык : ");
            string present_language = Console.ReadLine();

            foreach (Weather box in info)
            {
                if (box.WeatherRegion.inregion.Language == present_language)
                {

                    Console.WriteLine(box.ToString());
                   for (int j = 0 ; j < 6 ; j++)
                    {
                        WeatherLastSevenDays(box);//Генерируем значения погоды для 6 дней
                        Console.WriteLine(box.ToString());//Выводим каждый день
                    }


                }
            }

        }
        //Вывести среднюю температуру за прошедшую неделю в регионах с площадью больше заданной.
        public void WeatherInRegionArea(List<Weather> info)
        {
            Console.Write("Введите площадь : ");
            int area = Convert.ToInt32(Console.ReadLine());

            foreach (Weather box in info)
            {
                if (box.WeatherRegion.area > area)//Сравниваем площадь
                {
                    int temperature = 0;

                    temperature += box.Temperature;
                    for (int j = 0; j < 6; j++)
                    {
                        WeatherLastSevenDays(box);
                        temperature += box.Temperature;
                    }
                    Console.WriteLine($"Средняя температура за прошедшую неделю {temperature / 7} в регионе {box.WeatherRegion.Name}");
                }

            }
        }

    }
}
