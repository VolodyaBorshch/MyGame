using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MoneySystem : MonoBehaviour
{
    public int YouMoney;

    public TextMeshProUGUI textmoney;

    Player player;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            AddMoney();
        }
        SavePlayer();
    }

    public void AddMoney()
    {

        float _moneyForYou = Random.Range(60, 120);
        YouMoney += (int)_moneyForYou;
        textmoney.text = "" + YouMoney;
    }

    public void SavePlayer()
    {
        PlayerPrefs.SetInt("MoneyFinal", YouMoney);
    }
}
