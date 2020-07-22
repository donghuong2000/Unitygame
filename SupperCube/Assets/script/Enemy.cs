using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 100;
    public ParticleSystem ps;
    public Transform firePoint;
    public GameObject bulletpre;
    private float n = 2;
    public bool enemyDeath = false;
    
    int i=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        n += Time.deltaTime;
        Debug.Log(n);
        if(n > i)
        {
            i++;
            Shoot();
        }
        ps.transform.position = transform.position;
        if(health <= 0)
        {
            Destroy(gameObject);          
            ps.Play();
            enemyDeath = true;
            health = 100;
            
        }
        
    }

    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        health -= 20;
        
        
    }
    void Shoot()
    {
        Instantiate(bulletpre,firePoint.position,firePoint.rotation);
    }
   
}
