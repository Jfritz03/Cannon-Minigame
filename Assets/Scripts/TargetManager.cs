using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TargetManager : MonoBehaviour
{
    private float spawnRangeX = 12;
    private float spawnRangeY = 7;
    public GameObject target;
    private float startDelay = 2;
    private float spawnInterval = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTarget", startDelay, spawnInterval);
        ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnTarget()
    {
       Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(0, spawnRangeY), Random.Range(5, 12));
       Instantiate(target, spawnPos, transform.rotation);
        
    }
    
 
}
