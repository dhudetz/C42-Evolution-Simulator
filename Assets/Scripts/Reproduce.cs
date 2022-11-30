using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproduce : MonoBehaviour
{
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        myTimePerBirth = timePerBirth+ Random.Range(-2.0f,2.0f);
    }

    public float birthingDistance = 0.5f;
    public float timePerBirth = 3;
    private float myTimePerBirth;
    private float timeSinceBirth = 0;
    // Update is called once per frame
    void Update()
    {
        timeSinceBirth += Time.deltaTime;
        if(timeSinceBirth>myTimePerBirth){
            GameObject child = Instantiate(myPrefab, new Vector3(transform.position.x+Random.Range(-birthingDistance, birthingDistance), transform.position.y+Random.Range(-birthingDistance, birthingDistance), 0), Quaternion.identity);
            timeSinceBirth=0;
        }
    }
}
