using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float maxSpeed = 15.0f;
    public float JumpForce = 100f; 
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() 
    {
        if (rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce (0,0, speed/2,ForceMode.Impulse);
        }
        //rb.velocity = new Vector3(rb.velocity.x,rb.velocity.y,Time.deltaTime * speed);
        float h = Input.GetAxisRaw ("Horizontal");
        //rb.velocity = new Vector3 ((Time.deltaTime * speed )*h,rb.velocity.y,rb.velocity.z);
        if (h > 0 || h < 0)
        {
            rb.AddForce(h * speed,0,0,ForceMode.Impulse);
        }
        

        //float j = Input.GetAxisRaw("Jump"); 
        float DisstanceToTheGround = GetComponent<Collider>().bounds.extents.y;
 
         bool IsGrounded = Physics.Raycast(transform.position, Vector3.down, DisstanceToTheGround + 0.1f);
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {
            rb.AddForce (0, JumpForce,0,ForceMode.Impulse);
        }
    }
}
