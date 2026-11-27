using UnityEngine;
using System;
// using System.Globalization;
namespace com.manoj.sameName
{
    public class nameSpace12 : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        internal int Add(int a , int b)
        {
            return (a+b);
        }

        internal string BoolValue(string boolvalue)
        {
            switch(boolvalue)
            {
                case "1":
                case "true":
                case "True":
                return bool.TrueString;
                default:
                return bool.FalseString;
            }
        }

        internal T GetValue<T>(string key, T defaultValue = default)
        {
            var type = typeof(T);
            if(type == typeof(string))
            {
                return (T) Convert.ChangeType(key,type);
            }
            else if(type == typeof(int))
            {
                return (T) Convert.ChangeType(key,type);
            }
            else if(type == typeof(bool))
            {
                return (T) Convert.ChangeType(BoolValue(key),type);
            }
            else if(type == typeof(float))
            {
                return (T) Convert.ChangeType(key,type);
            }
            return defaultValue;
        }

        // internal void GetCultureInfo()
        // {
        //     int currency = 12345678;

        //     CultureInfo india = new CultureInfo("en-IN"); 
        //     CultureInfo us = new CultureInfo("en-US"); 
        //     CultureInfo french = new CultureInfo("fr-FR");
        //     CultureInfo denmark = new CultureInfo("de-DE"); 

        //     Debug.LogError($"{currency.ToString("C",india)}");
        //     Debug.LogError($"{currency.ToString("C",us)}");
        //     Debug.LogError($"{currency.ToString("C",french)}");
        //     Debug.LogError($"{currency.ToString("C",denmark)}");
        // }
    }
}

public class GameData<T>
{
    T Score;

    public void SetScore(T value)
    {
        Score = value;
    }

    public T GetScore()
    {
        return Score;
    }
}
