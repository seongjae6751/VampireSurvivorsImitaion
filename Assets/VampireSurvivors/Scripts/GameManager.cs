using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject characterSelect;
    public GameObject StageSelect;
    public GameObject powerUp;
    public GameObject options;
    // 캐릭터 창 키고 끄기.
    public void StartOnclick()
    {
        characterSelect.SetActive(true); 
    }
    public void characterSelectBack()
    {
        characterSelect.SetActive(false);
    }
    // 스테이지 선택 창 키고 끄기.
    public void CheckOnclick()
    {
        StageSelect.SetActive(true);
    }
    public void StageSelectBack()
    {
        StageSelect.SetActive(false);
    }
    // 강화 창 키고 끄기.
    public void PowerUpOnclick()
    {
        powerUp.SetActive(true);
    }
    public void powerUpBack()
    {
        powerUp.SetActive(false);
    }
    //  옵션 창 키고 끄기.
    public void OptionOnclick()
    {
        options.SetActive(true);
    }
    public void OptionBack()
    {
        options.SetActive(false);
    }

}
