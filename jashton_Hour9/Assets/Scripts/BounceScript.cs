using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceScript : MonoBehaviour
{
    private int bounceCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        bounceCount++;

        Debug.Log("Bounce! Total Bounces: " + bounceCount);
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
