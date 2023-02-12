using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 200f;
    private Transform playerTarget;
    private Rigidbody2D mybody;
    [HideInInspector]
    public EnemySpawner enemyspawner;
    public GameObject explosion;

    // Start is called before the first frame update
    void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        playerTarget = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (playerTarget == null)
            return;
        

        Vector2 point2Target = (Vector2)transform.position - (Vector2)playerTarget.position;
        point2Target.Normalize();

        float value = Vector3.Cross(point2Target, transform.up).z;

        mybody.velocity = transform.up * speed;
        mybody.angularVelocity = rotationSpeed * value;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="Mine" || collision.tag == "Player")
        {
            enemyspawner.ActivateSpawning();
            this.gameObject.SetActive(false);

            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
    
}
    