using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleController : MonoBehaviour
{
    // Private variables
    private int dir = 1;

    // Public variables
    public float maxScale = 35f;
    public float minScale = 5f;
    public float scaleChangeSpeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Scale 
        transform.localScale = transform.localScale + new Vector3(1,1,0) * scaleChangeSpeed * dir * Time.deltaTime;
        
        // Change direction if the max or min scales are exceeded
        if(transform.localScale.x > maxScale || transform.localScale.x < minScale)
            dir *= -1;
    }
}
