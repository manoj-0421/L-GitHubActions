using UnityEngine;
[CreateAssetMenu(fileName="School",menuName = "CreateAssetsMenu")]
public class CreateScriptable : ScriptableObject
{
   public StudentInfo studentInfo;
   public SchoolInfo schoolInfo;
    public string callback()
    {
        return $"{studentInfo.Name}, {studentInfo.Age}, {schoolInfo.Name}, {schoolInfo.CityName}";
    }
    public int add(int a, int b)
    {
        return (a+b);
    }
}
[System.Serializable]
public class StudentInfo
{
    public string Name;
    public string NickName;
    public int Age;
    public int RollNo;

    public int ClassNo;
}
[System.Serializable]
public class SchoolInfo
{
    public string Name;
    
    public string CityName;
    public int TeacherCount;

    public int YearsExp;
}