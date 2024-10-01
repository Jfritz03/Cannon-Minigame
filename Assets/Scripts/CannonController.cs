using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public float verticalInput;
    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 12;
    private float rotatespeed = 40;
    void Start()
    {
        
    }

   
    void Update()
    {
        //Moves cannon side to side
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
      
        //cannon rotates on the wrong axis
        verticalInput = Input.GetAxis("Vertical");
       // transform.Rotate(Vector3.up, rotatespeed * verticalInput * Time.deltaTime);
        transform.Rotate(verticalInput * rotatespeed * Time.deltaTime, 0.0f, 0.0f, Space.Self);

        //Keeps cannon in bounds
        if (transform.position.x < -xRange)
        { 
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
