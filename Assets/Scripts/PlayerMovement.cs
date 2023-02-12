using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    [SerializeField]private float speed = 3f;
    private Rigidbody2D rb;
    [SerializeField] private float rotationSpeed = 200f;
    public GameObject explosion;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        transform.Rotate(Vector3.forward * -horizontal * rotationSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="Enemy" || collision.tag=="Mine")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Invoke("RestartGame", 2f);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
    void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
