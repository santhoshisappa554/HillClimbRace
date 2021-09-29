using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    [SerializeField]
    private float speed,movement;
    [SerializeField]
    private Rigidbody2D Car;
    public Rigidbody2D backTire, FrontTire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      
    }
    /*private void FixedUpdate()
    {
            backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            FrontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            Car.AddTorque(-movement * speed * Time.fixedDeltaTime);
        

    }*/
    public void Movement()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase==TouchPhase.Began)
            {
                Touch touch1 = Input.GetTouch(0);
                Car.AddForce(transform.right * speed);
            }
        } 
    }
    
}
