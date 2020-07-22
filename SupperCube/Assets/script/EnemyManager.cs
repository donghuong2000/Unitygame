using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Enemy enemyF;
    public GameObject enemy;
    public Transform enemyTF;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyF.enemyDeath)
            createEnemy();
    }

    void createEnemy()
    {
        Instantiate(enemy,new Vector3(Random.Range(-5,5),enemyTF.position.y,enemyTF.position.z),enemyTF.rotation);
    }
}
