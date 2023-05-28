using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyforWhip : MonoBehaviour
{
    public int id;
    public int prefabId;
    public float damage;
    public int per;
    public int count;
    public float speed;
    public float timer = 0f;
    public GameObject whip;
    public bool isActive = false;
    public float activationTime = 2.0f;
    public float deactivationTime = 4.0f;

    public void Update()
    {
        timer += Time.deltaTime;

        if (!isActive && timer >= activationTime)
        {
            ActivateObject();
        }
        else if (isActive && timer >= deactivationTime)
        {
            DeactivateObject();
        }
    }

    private void ActivateObject()
    {
        whip.SetActive(true);
        isActive = true;
        timer = 0.0f;
    }

    private void DeactivateObject()
    {
        whip.SetActive(false);
        isActive = false;
        timer = 0.0f;
    }
}