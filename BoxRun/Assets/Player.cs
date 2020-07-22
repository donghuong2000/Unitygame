using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public Text score;
    public Rigidbody rb;
    public GameObject UIfinish;
    private Image Im;
    
    private bool Win = false;
    // Start is called before the first frame update
    public float Forward = 50f;
    public float sideWay = 1f;
    private void Start() 
    {
        Im = UIfinish.GetComponent<Image>();
    }
    private void FixedUpdate()
    {
        score.text = transform.position.z.ToString("0");
        rb.AddForce(Vector3.forward*Forward*Time.deltaTime);   
        if(Input.GetKey("d"))
        {
            rb.AddForce(Vector3.right*sideWay*Time.deltaTime*2f);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(Vector3.right*-sideWay*Time.deltaTime*2f);
        }
        if(rb.velocity.z > 6)
        {
            rb.velocity = new Vector3(rb.velocity.x,rb.velocity.y,6);
        }
        if(transform.position.y < -1f)
        {
             Invoke("Restart",2f);
        }
        if(Win)
        {
            Im.color = new Color(Im.color.r,Im.color.g,Im.color.b,Im.color.a+Time.deltaTime*2);
            Debug.Log(Im.color.a);
            if(Im.color.a >3)
            {
                
                this.enabled= false;
            }
        }
        
    }
    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag == "wall")
        {
            Debug.Log("end game");  
            this.enabled = false;
            Invoke("Restart",2f);
        }
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void OnTriggerEnter(Collider other) {
        if(other.transform.tag == "Finish")
        {
            UIfinish.SetActive(true);
            
            Win = true;            
        }
    } 
    public void thoat()
    {
        Application.Quit();
    }
    public void GoLeft()
    {
        rb.velocity = new Vector3(-5,rb.velocity.y,rb.velocity.z);
    }
    public void GoRight()
    {
        rb.velocity = new Vector3(5,rb.velocity.y,rb.velocity.z);
    }
}
