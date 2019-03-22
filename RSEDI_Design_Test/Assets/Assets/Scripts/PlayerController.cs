using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float jumpVelocity = 3f;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    public float rotSpeed = 5f;
    public float rot = 0f;
    protected Rigidbody2D rb2d;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
       
    }
   

    void FixedUpdate()
    {
       rot -= Input.GetAxis ("Horizontal") * rotSpeed;
        transform.eulerAngles = new Vector3(0.0f, 0.0f, rot);
 
       if (Input.GetButtonDown ("Jump"))
            Jump();
 
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
        if(rb2d.velocity.y < 0){
            rb2d.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb2d.velocity.y > 0 && !Input.GetButton ("Jump"))
            rb2d.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
    }

    //public void AddTorque(float torque, ForceMode2D mode = ForceMode2D.Force);

    

   
}
    
