using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firepoint : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletpre;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletpre,firePoint.position,firePoint.rotation);
    }
}
