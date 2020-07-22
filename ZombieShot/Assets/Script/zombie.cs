using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{
    public float Speed=2;
    public int healh=50;
    
    public GameObject Player;
    int damage=20;
    public GameObject zombiePrefab;
    public Transform baseWall;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
        movetoPlayer();
        if(healh<0)
        {
            healh=50;
            moreZombie();
            moreZombie();
            Destroy(gameObject);  
        }
        
    }
    void LookAtPlayer()
    {
        var dir = Player.transform.position - transform.position;
        var angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle,Vector3.forward);
    }
    void movetoPlayer()
    {
        Vector3 target = Player.transform.position;
        Vector3 current= transform.position;
       transform.position = Vector3.MoveTowards(current,target,Time.deltaTime*Speed);
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Weapon"))
        {
            healh-=damage;
        }
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("pot"))
        {
            Time.timeScale=0;
        }
    }
    void moreZombie()
    {
        Instantiate(zombiePrefab,new Vector3(8, Random.Range(-9,9), 0), Quaternion.identity);
    }
}

