using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool superPower;
    public Rigidbody rb;
    public float forwardForce = 4000f;
    public float sidewayForce = 100f;
    private bool jumpKeyWasPressed;
    private bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }
        // **horizontalInput = Input.GetAxis("Horizontal");**
    }
    void FixedUpdate()
    {
        //This code adds a force to the object
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //This code adds a force to the object when the key is inputted
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if (!isGrounded)
        {
            return;
        }
        if (jumpKeyWasPressed && superPower)
        {
            rb.AddForce(Vector3.up * 10, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
            isGrounded = true;
            superPower = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
     isGrounded = true;
    }
    private void OnCollisionExit(Collision collisionInfo)
    {
        isGrounded = false;   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            Destroy(other.gameObject);
            superPower = true;
        }
    }


}



    


       // if (rb.position.x < -7f)
        
           // FindObjectOfType<GameManager>().EndGame();
        
        //if (rb.position.x > 7f)
        
            //FindObjectOfType<GameManager>().EndGame();
       





        //This code allows player to controll the object with "a" and "d" horizontal keys to right and to left
        //**rb.velocity = new Vector3(horizontalInput * 5, rb.velocity.y, rb.velocity.z);**
    

  
        
    

