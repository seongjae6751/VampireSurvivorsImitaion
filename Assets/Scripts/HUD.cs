using System.Collections;
using System.Collections.Generic;
using TMPro;
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
                mytext.text = string.Format("Lv.{0:F0}",GameManager.instance.level);
                break;
            case InfoType.Kill:
                mytext.text = string.Format("{0:F0}", GameManager.instance.kill);
                break;
            case InfoType.Time:
                float remainTime = GameManager.instance.maxGameTime - GameManager.instance.gameTime;
                int min = Mathf.FloorToInt(remainTime / 60);
                int sec = Mathf.FloorToInt(remainTime % 60);
                mytext.text = string.Format("{0:02}:{1:0}", min, sec);
                break;
            case InfoType.Health:
                float curHealth = GameManager.instance.health;
                float maxHealth = GameManager.instance.maxhealth;
                myslider.value = curHealth / maxHealth;
                break;  
        }
    }
}
