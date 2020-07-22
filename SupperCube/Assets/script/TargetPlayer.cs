using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlayer : MonoBehaviour
{
    public GameObject player;
    Transform p1;
    // Start is called before the first frame update
    SpriteRenderer r1;
    void Start()
    {
        p1= player.GetComponent<Transform>();
        r1=gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        LookAtPlayer();
        flip();
    }
    void LookAtPlayer()
    {
        var dir = p1.position - transform.position;
        var angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle,Vector3.forward);
    }
    void flip()
    {
        var p = transform.rotation.z;
        if(p > -0.7 && p < 0.7)
        {
            r1.flipY = false;

        }
        else
            r1.flipY = true;
    }
}
