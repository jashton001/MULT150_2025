using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class StationaryCat : MonoBehaviour
{
    public Transform spawnPoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("GAME OVER \n L in the chat");

            CharacterController cc = other.GetComponent<CharacterController>();

            if (cc != null)
            {
                cc.enabled = false;

                if (spawnPoint != null)
                {
                    other.transform.position = spawnPoint.position;
                }
                else
                {
                    other.transform.position = new Vector3(0, 1, 0);
                }
                cc.enabled = true;
            }
        }
    }
}
