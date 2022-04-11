using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simple : MonoBehaviour
{
    // private string DataJson = "{"name":"Dr Charles","lives":3,"health":0.8}";
    public PlayerInfo m_PlayerInfo;

    public TextAsset m_jsonfile;
    void Start()
    {
        m_PlayerInfo = CreateFromJSON(m_jsonfile.text);
    }
    public static PlayerInfo CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<PlayerInfo>(jsonString);
    }
}
[System.Serializable]
public class PlayerInfo
{
    public string name;
    public int lives;
    public float health;

   

    // Given JSON input:
    // {"name":"Dr Charles","lives":3,"health":0.8}
    // this example will return a PlayerInfo object with
    // name == "Dr Charles", lives == 3, and health == 0.8f.
}
