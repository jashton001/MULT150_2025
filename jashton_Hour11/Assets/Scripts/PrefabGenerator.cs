using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject streetLampPrefab;

    // Start is called before the first frame update
    void Start()
    {
        float spacing = 5f;

        Vector3 spawnPosition = transform.position;

        for (int i = 0; i < 10; i++)
        {
            spawnPosition.x = transform.position.x + (i * spacing);

            Instantiate(streetLampPrefab, spawnPosition, Quaternion.identity); 
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(streetLampPrefab, transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject[] lamps = GameObject.FindGameObjectsWithTag("Lamp");
            foreach (GameObject lamp in lamps)
            {
                Destroy(lamp);
            }
        }
    }
}
