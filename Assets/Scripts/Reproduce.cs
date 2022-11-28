using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproduce : MonoBehaviour
{
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float birthingDistance = 0.5f;
    public int frameDivider = 100;
    private int counter = 0;
    // Update is called once per frame
    void Update()
    {
        counter++;
        counter+=Random.Range(1,frameDivider);
        if(counter%frameDivider == 0){
            GameObject child = Instantiate(myPrefab, new Vector3(transform.position.x+Random.Range(-birthingDistance, birthingDistance), transform.position.y+Random.Range(-birthingDistance, birthingDistance), 0), Quaternion.identity);
        }
    }
}
