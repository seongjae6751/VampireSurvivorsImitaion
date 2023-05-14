using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    Rigidbody2D rigid;
    SpriteRenderer rend;
    public float speed;
    public ButtonController Buttoncontroller;
    Animator anim;
    public Vector2 inputVec;
    float h;
    float v;

    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rend.flipX = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) 
        { 
            rend.flipX = true; 
        }   

    }

    private void FixedUpdate()
    {
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;

        // ��ġ �̵�
        rigid.MovePosition(rigid.position + nextVec);
    }
}
