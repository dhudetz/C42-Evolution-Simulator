using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float timePerDeath = 1.0f;
    // Update is called once per frame
    void Update()
    {         
        Destroy(gameObject, timePerDeath);
    }
    
}
