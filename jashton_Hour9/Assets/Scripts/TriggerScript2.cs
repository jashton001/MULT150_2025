using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript2 : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.GetComponent<MotionScript>())
        {
            Debug.Log(other.gameObject.name + ": ENTERED the trigger.");
        }
    }

    void OnTriggerStay (Collider other)
    {
        if(other.gameObject.GetComponent<MotionScript>())
        {
            Debug.Log(other.gameObject.name + ": STAYING in the trigger.");
        }
    }

    void OnTriggerExit (Collider other)
    {
        if(other.gameObject.GetComponent<MotionScript>())
        {
            Debug.Log(other.gameObject.name + ": EXITED the trigger.");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
