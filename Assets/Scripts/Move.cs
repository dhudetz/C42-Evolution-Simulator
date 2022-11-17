using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float moveSpeed = 5.0f;
    public Vector2 neuralNetworkWeights;
    public float randomBound = 5.0f;
    //private float scale = 0;
    void Update()
    {
        neuralNetworkWeights.x = 1;
        //scale+=0.1;
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");
        //transform.scale = new Vector3(scale,scale,scale);
        //update the position
        //transform.position = transform.position + new Vector3(horizontalInput * moveSpeed * Time.deltaTime, verticalInput * moveSpeed * Time.deltaTime, 0);
        transform.position = new Vector3(Random.Range(-randomBound, randomBound), Random.Range(-randomBound, randomBound), 0);

        //output to log the position change
        Debug.Log(transform.position);
    }
}
