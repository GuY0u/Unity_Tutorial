using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_T11 : MonoBehaviour
{
    [SerializeField] private Text txt_name;
    [SerializeField] private Image img_name;
    [SerializeField] private Sprite sprite;

    private bool isCoolTime = false;

    private float currentTime = 1f;
    private float delayTime = 5f;

    private void Update()
    {

        img_name.color = Color.red;

        if (isCoolTime)
        {
            currentTime -= Time.deltaTime;
            img_name.fillAmount = currentTime / delayTime;

            if (currentTime <= 0)
            {
                isCoolTime = false;
                currentTime = delayTime;
                img_name.fillAmount = currentTime;
            }
        }
    }

    public void Change()
    {
        txt_name.text = "변경됨";
        isCoolTime = true;
    }

}
