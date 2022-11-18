using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PopulationCounter : MonoBehaviour
{
    public Text textUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string popCount = ((GameObject.FindGameObjectsWithTag("Organism")).Length).ToString();
        textUI.text = "Population: " + popCount;
    }
}
