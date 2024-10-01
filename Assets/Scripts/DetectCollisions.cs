using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{// cannonballs delete the ground on impact
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target")) // destroys cannonball and target on collision
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
