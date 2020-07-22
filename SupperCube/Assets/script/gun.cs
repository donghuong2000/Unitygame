using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    // Start is called before the first frame update
    Transform p1;

    SpriteRenderer r1;
    void Start()
    {
        p1=gameObject.GetComponent<Transform>();
        r1=gameObject.GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        LookAtMouse();
        flip();
    }
    void LookAtMouse()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
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
        //Debug.Log(p);

        
    }
}
