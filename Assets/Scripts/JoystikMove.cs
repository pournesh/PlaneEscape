using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystikMove : MonoBehaviour
{
    public FixedJoystick stick;
    Rigidbody2D rb;
    Vector2 move;
    public float movespeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(stick.Horizontal != 0 && stick.Vertical !=0)
        {
            move.x = stick.Horizontal;
            move.y = stick.Vertical;
            movespeed = 4;

        }
        

        float haxix = move.x;
        float yaxix = move.y;
        float zaxix = Mathf.Atan2(haxix, yaxix) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0f, 0f, -zaxix);
    }
    private void FixedUpdate()
    {

        rb.MovePosition(rb.position + move * movespeed * Time.fixedDeltaTime);
    }
}
