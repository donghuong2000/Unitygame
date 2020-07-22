using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed=50, maxSpeed=3,jumpPow=100f;
    bool grcheck;
    public float health = 200;
    int dem=0;
    // Start is called before the first frame update
    Rigidbody2D r2;
    void Start()
    {
        r2=gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(grcheck || dem < 1)
        {
             if(Input.GetKeyDown(KeyCode.Space))
             {
                  r2.AddForce((Vector2.up)*jumpPow);
                  dem++;
                  
                  if(dem==2)
                  {
                      dem=0;
                  }
                    
             }
        }
        if (health <= 0 || transform.position.y < -10)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }   
     void FixedUpdate() 
    {
        float x = Input.GetAxis("Horizontal");
        r2.AddForce((Vector2.right)*x*speed);
        if(r2.velocity.x>maxSpeed)
        {
            r2.velocity= new Vector2(maxSpeed,r2.velocity.y);
        }
        if(r2.velocity.x<-maxSpeed)
        {
            r2.velocity= new Vector2(-maxSpeed,r2.velocity.y);
        }
    }
     void OnCollisionEnter2D(Collision2D other)
    { 
          
        if(other.gameObject.CompareTag("ground"))
        {
            grcheck=true;
        }       
    }
     void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.CompareTag("ground"))
        {          
            grcheck=false;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("bullet"))
        {
            health -= 20;
        }
    }
}