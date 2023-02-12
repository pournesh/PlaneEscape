using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(transform.position.y < -6)
        {
            this.gameObject.SetActive(false);
        }
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy" || collision.tag =="Player")
        {
            collision.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
