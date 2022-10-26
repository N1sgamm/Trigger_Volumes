using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChangeMaterial : MonoBehaviour
{
    public Material TriggerOff;
    public Material TriggerOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter()
    {
        GetComponent<Renderer>().material = TriggerOn;
    }

    void OnTriggerExit()
    {
        GetComponent<Renderer>().material = TriggerOff;
    }
}
