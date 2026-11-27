using UnityEngine;
namespace com.manoj.sameName
{
    public class nameSpace11 : nameSpace12
    {
        string IntData = "43";
        string BoolData = "1";
        string FloatData = "24.5";
        GameData<int> Score;
        GameData<string> Str;
        void Start()
        {
            int c = Add(12,23);
            int Tcase = GetValue<int>(IntData);
            bool Tcase1 = GetValue<bool>(BoolData);
            float Tcase2 = GetValue<float>(FloatData);
            // GetCultureInfo();
            Score = new();
            Score.SetScore(12);
            Str = new();
            Str.SetScore("Twenty");
        }
    }
}
