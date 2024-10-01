using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TargetTimer : MonoBehaviour
{
    private float delay = 10f;
    public GameObject target;
    public GameObject cannon;
    void Start()
    {
        Invoke("Delete", delay); // calls for function to delete target after delay
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  //Deletes Target
    void Delete() {
    Destroy(target);
    Debug.Log("Game Over!");
    
    }
    
      
    
}
