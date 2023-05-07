using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject characterSelect;
    public GameObject StageSelect;
    public GameObject powerUp;
    public GameObject options;
    // ĳ���� â Ű�� ����.
    public void StartOnclick()
    {
        characterSelect.SetActive(true); 
    }
    public void characterSelectBack()
    {
        characterSelect.SetActive(false);
    }
    // �������� ���� â Ű�� ����.
    public void CheckOnclick()
    {
        StageSelect.SetActive(true);
    }
    public void StageSelectBack()
    {
        StageSelect.SetActive(false);
    }
    // ��ȭ â Ű�� ����.
    public void PowerUpOnclick()
    {
        powerUp.SetActive(true);
    }
    public void powerUpBack()
    {
        powerUp.SetActive(false);
    }
    //  �ɼ� â Ű�� ����.
    public void OptionOnclick()
    {
        options.SetActive(true);
    }
    public void OptionBack()
    {
        options.SetActive(false);
    }

}
