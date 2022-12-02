using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Define move speed
    public float moveSpeed = 5.0f;
    
    // Update function
    void Update()
    {
        // Every update, move the agent by random range
        transform.position += new Vector3(Random.Range(-moveSpeed, moveSpeed), Random.Range(-moveSpeed, moveSpeed), 0) * Time.deltaTime;
    }
}
