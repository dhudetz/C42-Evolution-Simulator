using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float targetTime = 1.0f;
    // Update is called once per frame
    void Update()
    {         
      /*  targetTime -= Time.deltaTime;
 
        if (targetTime <= 0.0f)
        {
           timerEnded();
        }*/
    
  //  void timerEnded()
    //{
        Destroy(gameObject, 5);
    //}
    }
    
}
