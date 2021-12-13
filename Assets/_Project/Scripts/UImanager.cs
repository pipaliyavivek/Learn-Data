using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Sirenix.OdinInspector;
using DG.Tweening;

public class UImanager : MonoBehaviour
{
    public static UImanager Instance;
    public TextMeshProUGUI mCoinText;
    public TextMeshProUGUI mDaimondText;

    private int coinValue;
    private int daimondValue;

    public GameObject SettingPenal;
    public Button OpenSetting;
    public Button CloseSetting;

    public Button Music;
    public Button Sound;
    public Button vibration;

    public Sprite MusicOn;
    public Sprite MusicOff;
    public Sprite SoundOn;
    public Sprite SoundOff;
    public Sprite vibrationOn;
    public Sprite vibrationOff;

    public bool IsMusic;
    public bool IsSound;
    public bool IsVibration;

    public int CoinValue
    {
        get { return PlayerPrefs.GetInt(nameof(CoinValue)); }
        set { PlayerPrefs.SetInt(nameof(CoinValue), value); }
    }
    public int DaimondValue
    {
        get { return PlayerPrefs.GetInt(nameof(DaimondValue)); }
        set { PlayerPrefs.SetInt(nameof(DaimondValue), value); }
    }

    private void Awake() => Instance = this;

    private void Start()
    {
        OpenSetting.onClick.AddListener(OpenSettingMethod);
        CloseSetting.onClick.AddListener(closeSettingmethod);
        Music.onClick.AddListener(ForMusic);
        Sound.onClick.AddListener(ForSound);
        vibration.onClick.AddListener(ForVibration);

        IsMusic = PlayerPrefs.GetInt("IsMusic") == 1 ? true : false;
        IsVibration = PlayerPrefs.GetInt("IsVibration") == 1 ? true : false;
        IsSound = PlayerPrefs.GetInt("IsSound") == 1 ? true : false;

        ForMusic();
        ForVibration();
        ForSound();
    }
    private void FixedUpdate()
    {
        mCoinText.text = CoinValue.ToString();
        mDaimondText.text = DaimondValue.ToString();
    }
    void OpenSettingMethod()
    {
        SettingPenal.SetActive(true);
        SettingPenal.transform.DOScale(Vector3.one, 0.6f);
    }
    void closeSettingmethod()
    {
        SettingPenal.transform.DOScale(Vector3.zero, 0.4f).OnComplete(() =>
        {
            SettingPenal.SetActive(true); 
        });
    }
    public void ForMusic()
    {
        PlayerPrefs.SetInt("IsMusic", IsMusic ? 1 : 0);
        IsMusic = !IsMusic;
        if (IsMusic)
        {
            Music.transform.GetChild(0).GetComponent<Image>().sprite = MusicOn;
        }
        else
        {
            Music.transform.GetChild(0).GetComponent<Image>().sprite = MusicOff;
        }
    }
    public void ForSound()
    {
        PlayerPrefs.SetInt("IsSound", IsSound ? 1 : 0);
        IsSound = !IsSound;
        if (IsSound)
        {
            Sound.transform.GetChild(0).GetComponent<Image>().sprite = SoundOn;
        }
        else
        {
            Sound.transform.GetChild(0).GetComponent<Image>().sprite = SoundOff;
        }
    }
    public void ForVibration()
    {
        PlayerPrefs.SetInt("IsVibration", IsVibration ? 1 : 0);
        IsVibration = !IsVibration;
        if (IsVibration)
        {
            vibration.transform.GetChild(0).GetComponent<Image>().sprite = vibrationOn;
        }
        else
        {
            vibration.transform.GetChild(0).GetComponent<Image>().sprite = vibrationOff;
        }
    }
}
