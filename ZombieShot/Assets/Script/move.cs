using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    Transform r2 ;
    // Start is called before the first frame update
    void Start()
    {   
        speed=3;
        r2=gameObject.GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        r2.Translate(new Vector2(x,y)*Time.deltaTime*speed);
        
    }
    
}