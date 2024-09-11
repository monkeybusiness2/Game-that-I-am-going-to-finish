using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float velocity = 10;
    float jumpheight = 10;
    bool isgrounded;
    bool isJumpPressed;
    public Rigidbody rb;
    public Rigidbody Floor;
    
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isgrounded = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isJumpPressed = Input.GetButtonDown("Jump");
        if (isJumpPressed)
        {
            rb.velocity = new Vector3(0,3,1);
            isgrounded = true;
        }
        

    

    }
}
