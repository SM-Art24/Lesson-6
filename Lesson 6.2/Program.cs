using System;
using System.Collections.Generic;

namespace Lesson_6._2
{

    /* 7. Погода.В сущностях(типах) хранится информация о погоде в различных регионах.
Для погоды необходимо хранить:
— регион;
— дату;
— температуру;
— осадки.
Для регионов необходимо хранить:
— название;
— площадь;
— тип жителей.
Для типов жителей необходимо хранить:
— название;
— язык общения.
Вывести сведения о погоде в заданном регионе.
Вывести даты, когда в заданном регионе шел снег и температура была ниже заданной отрицательной.
Вывести информацию о погоде за прошедшую неделю в регионах, жители которых общаются на заданном языке.
Вывести среднюю температуру за прошедшую неделю в регионах с площадью больше заданной.
*/




    class Program
    {


        static void Main(string[] args)
        {
         
            List<Weather> GeneralWeatherInfo = new();
           
            //Изначальная информация
            TypePeople FirstPeople = new ("Американцы", "Английский");
            TypePeople SecondPeople = new ("Итальянцы", "Итальянский");
            TypePeople ThirdPeople = new("Британцы", "Английский");

            Region FirstRegion = new ("Детройт", 370, FirstPeople);
            Region SecondRegion = new ("Рим", 1300, SecondPeople);
            Region ThirdRegion = new ("Лондон", 1500, ThirdPeople);

            DateTime someDate = new (2020, 12, 5);//Изначальная дата
            GeneralWeatherInfo.Add(new Weather (FirstRegion, someDate, -15, "Снег"));

            GeneralWeatherInfo.Add(new Weather(SecondRegion, someDate, 10, "Облачно"));

            GeneralWeatherInfo.Add (new Weather(ThirdRegion, someDate, -14, "Снег"));



            //Меню для пользователя
            Console.WriteLine("_______Menu_______" +
                "\n1)Сведения о погоде в заданном регионе" +
                "\n2)Даты, когда в заданном регионе шел снег и температура была ниже заданной отрицательной." +
                "\n3)Информация о погоде за прошедшую неделю в регионах, жители которых общаются на заданном языке." +
                "\n4)Средняя температура за прошедшую неделю в регионах с площадью больше заданной." +
                "\n5)Выход");
            Weather Result = new Weather();
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Weather.WeatherInPresentRegion(GeneralWeatherInfo);
                    break;

                case 2:
                    Weather.WeatherRegionDate(GeneralWeatherInfo);
                    break;

                case 3:
                    Result.WeatherInRegionLanguage(GeneralWeatherInfo);
                    break;
                case 4:
                    Result.WeatherInRegionArea(GeneralWeatherInfo);
                     break;
                case 5:
                    Environment.Exit(0);
                    break;
                  
            }

        }
    }
}
