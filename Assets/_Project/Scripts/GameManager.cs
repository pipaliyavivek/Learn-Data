using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake() => Instance = this;
    private string URL = "http://localhost/justdemo.txt";
    public Button responsebtn;
    public TextMeshProUGUI responseText;
    public PlayerList myplayrtlist = new PlayerList();

    void Start()
    {
        StartCoroutine(getdata());
    }
    IEnumerator getdata()
    {
        WWW _www = new WWW(URL);
        yield return _www;
        if (_www.error == null)
        {
            ProcessData(_www.text);
        }
        else
        {
            Debug.Log("Wrong Something!!!!!!!");
        }
    }
    public void ProcessData(string _url)
    {
        myplayrtlist = JsonUtility.FromJson<PlayerList>(_url);
    }
}
[System.Serializable]
public class player
{
    public string Name;
    public int Health;
    public int mana;
    public string Img;

}
[System.Serializable]
public class PlayerList
{
    public player[] player;
}




