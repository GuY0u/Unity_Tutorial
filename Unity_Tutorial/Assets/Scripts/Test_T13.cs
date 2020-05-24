using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_T13 : MonoBehaviour
{
    [SerializeField] private Text txt_money;
    [SerializeField] private InputField inputTxT_money;

    private int currentMoney;


    public void Input()
    {
        currentMoney += int.Parse(inputTxT_money.text);

        txt_money.text = currentMoney.ToString();
    }

    public void OutPut()
    {
        currentMoney -= int.Parse(inputTxT_money.text);

        txt_money.text = currentMoney.ToString();
    }
}
