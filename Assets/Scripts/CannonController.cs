using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public float verticalInput;
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 5;
    public float rotatespeed = 5.0f;
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
        transform.Rotate(Vector3.up, rotatespeed * verticalInput * Time.deltaTime);
        
        
        
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
