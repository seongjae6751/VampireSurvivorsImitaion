using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;

public class InfiniteTiles : MonoBehaviour
{
    Collider2D coll;

    void Awake()
    {
        coll = GetComponent<Collider2D>();
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Area"))
            return;
        Vector3 playerPos = GameManager.instance.player.transform.position;
        Vector3 myPos = transform.position;
        Vector3 playerDir = GameManager.instance.player.inputVec;

        float dirX = playerPos.x - myPos.x;
        float dirY = playerPos.y - myPos.y;

        float diffx = Mathf.Abs(dirX);
        float diffy = Mathf.Abs(dirY);

        dirX = dirX > 0 ? 1 : -1;
        dirY = dirY > 0 ? 1 : -1;

        switch (transform.tag)
        {
            case "ground":
                if (Mathf.Abs(diffx - diffy) <= 0.1f)
                {
                    transform.Translate(Vector3.up * dirY * 10);
                    transform.Translate(Vector3.right * dirX * 18);
                }
                else if (diffx > diffy)
                {
                    transform.Translate(Vector3.right * dirX * 36);
                }
                else if (diffx < diffy)
                {
                    transform.Translate(Vector3.up * dirY * 20);
                }
                break;
            case "Enemy":
                if (coll.enabled)
                {
                    transform.Translate(playerDir * 18 + new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), 0f));
                }
                break;
        }
    }
}
