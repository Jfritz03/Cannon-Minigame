using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject projectile;
    public float Velocity = 700f;
    void Start()
    {
        
    }

    
    void Update()
    {
        //GetKeyDown - NOT GetButtonDown
       if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, Velocity,0));
        }
    }
}
