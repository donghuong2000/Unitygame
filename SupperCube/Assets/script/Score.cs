using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int score;
    public Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy.enemyDeath)
            {
                score += 5;
                scoreText.text = "Score : " + score;
                enemy.enemyDeath = false;
            }
    }
}
