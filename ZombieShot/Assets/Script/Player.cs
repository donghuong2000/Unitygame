using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{ 
    public GameObject move;
    Transform r2 ;
    public int ourHealth= 10;
    public int maxHealth = 10;
    // Start is called before the first frame update
    void Start()
    {   
        move = GameObject.FindGameObjectWithTag("pot");
        r2=gameObject.GetComponent<Transform>();
        ourHealth= 10;
    }

    // Update is called once per frame
    void Update()
    {
        LookAtMouse();
        tagetPot();

    }
    void LookAtMouse()
    {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle,Vector3.forward);
    }
    void tagetPot()
    {
        Vector3 u = move.transform.position;
        r2.position= u;
    }
}
