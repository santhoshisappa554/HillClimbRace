using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D backTire, FrontTire;
    public float speed, movement;
    public Rigidbody2D car;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }
    public void FixedUpdate()
    {
        backTire.AddTorque(-movement*speed*Time.fixedDeltaTime);
        FrontTire.AddTorque(-movement * speed* Time.fixedDeltaTime);
        car.AddTorque(-movement * speed * Time.fixedDeltaTime);
        
    }
}
