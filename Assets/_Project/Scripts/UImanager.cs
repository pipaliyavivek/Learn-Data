using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Sirenix.OdinInspector;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI mCoinText;
    public TextMeshProUGUI mDaimondText;

    private int coinValue;
    private int daimondValue;

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
    private void FixedUpdate()
    {
        mCoinText.text = CoinValue.ToString();
        mDaimondText.text = DaimondValue.ToString();
    }
    [Button]
    void setCoinValue(int val)
    {
        CoinValue = val;
    }
}
