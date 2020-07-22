using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 40;
    public Rigidbody2D ry;
    // Start is called before the first frame update
    void Start()
    {

        ry.velocity= transform.right*speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
}
