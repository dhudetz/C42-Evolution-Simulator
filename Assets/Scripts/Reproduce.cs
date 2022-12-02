using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproduce : MonoBehaviour
{
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        // Generate a value for how much time it takes to birth with randomized value
        myTimePerBirth = timePerBirth + Random.Range(-randomBirthVariable, randomBirthVariable);
    }

    // Define variables
    public float colorChange = 0.05f;
    public float birthingDistance = 0.5f;
    public float timePerBirth = 3f;
    public float randomBirthVariable = 1.5f;
    private float myTimePerBirth;
    private float timeSinceBirth = 0f;

    // Birth new agent
    void Birth(){
        // Instantiate the child object
        GameObject child = Instantiate(myPrefab, new Vector3(transform.position.x+Random.Range(-birthingDistance, birthingDistance), transform.position.y+Random.Range(-birthingDistance, birthingDistance), 0), Quaternion.identity);
        
        // Store the value of this agent's color
        Color oldColor = child.GetComponent<SpriteRenderer>().color;

        //Give the new child agent a color that is slightly randomized from the parent's color
        child.GetComponent<SpriteRenderer>().color = new Color(oldColor.r+Random.Range(-colorChange, colorChange), oldColor.g+Random.Range(-colorChange, colorChange), oldColor.b+Random.Range(-colorChange, colorChange), oldColor.a+Random.Range(-colorChange, colorChange));
    }

    // Update is called once per frame
    void Update()
    {
        // Count time since the last birth
        timeSinceBirth += Time.deltaTime;

        // If the time since birth exceeds the time it takes for the agent to birth a new agent, birth
        if(timeSinceBirth>myTimePerBirth){
            Birth();
            timeSinceBirth=0;
        }
    }
}

