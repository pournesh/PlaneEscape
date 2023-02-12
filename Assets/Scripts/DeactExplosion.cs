using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactExplosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Deactivate", 2f);
    }
    void Deactivate()
    {
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
