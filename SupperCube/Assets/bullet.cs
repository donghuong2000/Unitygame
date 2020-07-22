using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    Rigidbody2D rb ;

     void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log(other.name);
        Destroy(gameObject);
    }

 
}
