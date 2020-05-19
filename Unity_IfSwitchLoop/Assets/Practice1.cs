using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Practice1 : MonoBehaviour
{
    public HP HealthPoint;
    public Text result;
    public Slider slider;

    private void Update()
    {
        HealthPoint.hp = slider.value;
        if (HealthPoint.hp >= 70)
        {
            result.text = "安全";
        }

        if (HealthPoint.hp >= 30 && HealthPoint.hp < 70)
        {
            result.text = "警告";
        }

        if (HealthPoint.hp < 30)
        {
            result.text = "危險";
        }
        

    }
}
