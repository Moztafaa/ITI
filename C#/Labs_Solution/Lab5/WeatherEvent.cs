using System;

namespace Lab5;

/*
Using events write a function to print a message according to the celsius degree
e.g. user enter the degree in print it in fahrenheit -> print it in Celsius degree + message for
if degree >= 40 -> print very hot
if degree < 40 >= 30 -> print hot
if degree <= 29 moderate temperature
*/

public delegate void WeatherHandler();
public class WeatherEvent
{
    public delegate void WeatherHandler(string message);
    public event WeatherHandler? WeatherChanged;

    public void CheckTemperature(int celsius)
    {
        double fahrenheit = CelsiusToFahrenheit(celsius);
        string message = $"Temperature: {celsius}°C ({fahrenheit}°F) - ";

        if (celsius >= 40)
        {
            message += "Very hot";
        }
        else if (celsius >= 30)
        {
            message += "Hot";
        }
        else
        {
            message += "Moderate temperature";
        }

        WeatherChanged?.Invoke(message);
    }
    // public event WeatherHandler? WeatherVeryHot;
    //     public event WeatherHandler? WeatherHot;
    //     public event WeatherHandler? WeatherModerate;

    //     public void OnWeatherVeryHot() => WeatherVeryHot?.Invoke();
    //     public void OnWeatherHot() => WeatherHot?.Invoke();
    //     public void OnWeatherModerate() => WeatherModerate?.Invoke();


    public static double CelsiusToFahrenheit(int celsius) => (celsius * 9 / 5) + 32;
}