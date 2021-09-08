using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement instance;
    public Rigidbody2D backTire, FrontTire;
    public float speed, movement;
    public Rigidbody2D car;
    public float fuel, fuelConsumption;
    public Image fuelImage;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        fuelImage.fillAmount = fuel;
    }
    private void FixedUpdate()
    {
        if (fuel > 0)
        {
            backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            FrontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            car.AddTorque(-movement * speed * Time.fixedDeltaTime);
        }
       
        fuel = fuel - fuelConsumption*Time.deltaTime*Mathf.Abs(movement);
        
    }
    
}
