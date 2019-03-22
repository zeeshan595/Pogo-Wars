using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotSpeed = 5f;
    public float rot = 0f;
    public Rigidbody2D rb2d;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

    }
   

    // Update is called once per frame
    void FixedUpdate()
    {
       rot -= Input.GetAxis ("Horizontal") * rotSpeed;
        transform.eulerAngles = new Vector3(0.0f, 0.0f, rot);
    }

    public void AddTorque(float torque, ForceMode2D mode = ForceMode2D.Force);

    

   /*  private void Movement(float h)
    {
         rot -= Input.GetAxis ("Horizontal") * rotSpeed;
         transform.eulerAngles = new Vector3(0.0f, rot, 0.0f);
    }
    */
}
    
