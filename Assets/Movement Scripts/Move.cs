using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    private Rigidbody2D rb;
    private float horizontal, vertical;
    float angle;
    private float rotationSpeed = 200f;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        angle = Mathf.Atan2(vertical, horizontal) * Mathf.Rad2Deg;
        rotate();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, vertical) * speed * Time.deltaTime;

    }

    void rotate()
    {
        transform.Rotate(Vector3.forward * -horizontal * rotationSpeed * Time.deltaTime);
    }
}
