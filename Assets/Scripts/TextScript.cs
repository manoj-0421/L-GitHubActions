using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
[HelpURL("https://www.google.com")]
public class TextScript : MonoBehaviour
{
    public enum Status
    {
        BATSMAN,
        BOWLER,
        FIELDER
    }

    public enum Gender
    {
        MALE,
        FEMALE
    }
    
    [SerializeField]
    TMP_Text TextStyle;
    [SerializeField]
    int value = 25;

    [SerializeField]
    Status m_status;
    [SerializeField]
    Gender m_gender;
    [Tooltip("Here you can view the player details")]
    [SerializeField]
    List<CarrerDetails> PlayerDetails = new List<CarrerDetails>();

    int health = 100;
    
    public int m_health => health;
    [Range(1,10)]
    public int SliderValue;

    void Start()
    {
        // Debug.unityLogger.logEnabled = true;
        // TextStyle.text = $"<style=Link>This function</style> is called in start <style=H1>{value}</style>";
        // Debug.LogError($"Level Index : {PlayerDetails[0].Id}, Level Name : {PlayerDetails[0].Name}");
        // Debug.LogError($"Gender : {m_gender}, Status : {m_status}, Health : {health}");
    }
}

[Serializable]
public class Batsman
{
   public int Id;
}
[Serializable]
public class PersonnalInfo : Batsman
{
    public string Name;
    public string NickName;
    public float Height;
    public int Weight;
}
[Serializable]
public class CarrerDetails : PersonnalInfo
{
    public int TotalRunsScored;
    public int TotalBallsFaced;
    public int NoofFours;
    public int NoofSixes;
    public float Average;
}


