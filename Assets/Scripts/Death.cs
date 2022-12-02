using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject survivalBound;

    // Start is called before the first frame update
    void Start()
    {
        survivalBound = GameObject.Find("Survival Bound");
    }
    public float timePerDeath = 1.0f;
    // Update is called once per frame
    void Update()
    {
        // Define variables for the position of this agent, the boundary object, and the the scale of the boundary object
        float thisPosX = transform.position.x;
        float boundPosX = survivalBound.transform.position.x;
        float boundScaleX = survivalBound.transform.localScale.x / 2;
        float thisPosY = transform.position.y;
        float boundPosY = survivalBound.transform.position.y;
        float boundScaleY = survivalBound.transform.localScale.y / 2;
        
        // Use the variables defined above to store the conditions of if the agent has left the boundary
        bool xBoundCheck =  thisPosX < boundPosX - boundScaleX || thisPosX > boundPosX + boundScaleX;
        bool yBoundCheck = thisPosY < boundPosY - boundScaleY || thisPosY > boundPosY + boundScaleY;
        if(xBoundCheck || yBoundCheck){
            Destroy(gameObject);
        }
        Destroy(gameObject, timePerDeath);
    }
}
