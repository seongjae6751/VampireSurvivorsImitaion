using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public enum InfoType { Exp, Level, Kill, Time, Health}
    public InfoType type;

    Text mytext;
    Slider myslider;
    // Start is called before the first frame update
    void Awake()
    {
        mytext = GetComponent<Text>(); 
        myslider = GetComponent<Slider>();
    }
    // Update is called once per frame
    void LateUpdate()
    {
        switch (type)
        {
            case InfoType.Exp:
                float curExp = GameManager.instance.exp;
                float maxExp = GameManager.instance.nextExp[GameManager.instance.level];
                myslider.value = curExp / maxExp;
                break;
            case InfoType.Level:

                break;
            case InfoType.Kill:

                break;
            case InfoType.Time:
                
                break;
            case InfoType.Health:

                break;  
        }
    }
}
