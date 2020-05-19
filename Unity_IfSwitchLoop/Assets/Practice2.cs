using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Practice2 : MonoBehaviour
{
    public InputField text;
    public Text result;

    
    private void Update()
    {
       
         result.text = text.text == "紅水" ? "恢復血量" : text.text=="藍水" ? "恢復魔力":"";
    }
}
