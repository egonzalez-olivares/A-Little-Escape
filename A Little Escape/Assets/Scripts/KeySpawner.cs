using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    public GameObject[] KeySpawnPoints;
    public Hashtable checkKeySpawn;
    int picked;

    void Start()
    {
        checkKeySpawn = new Hashtable();

        for (int i = 0; i < 12; i++)
        {
            KeySpawnPoints[i].SetActive(false);
        }

        // for-loop to pick 3 random key spawn points
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("Loop " + i);

            picked = Random.Range(0, 11);

            // check if there's an element inside checkKeySpawn
            if (checkKeySpawn.Count != 0)
            {
                if (checkKeySpawn.Contains(picked))
                {
                    // go back one loop iteration
                    Debug.Log("Went back a loop iteration. i: " + i);
                    Debug.Log("Repeated Pick: " + picked);
                    i -= 1;
                    continue;
                }
            }

            KeySpawnPoints[picked].SetActive(true);
            checkKeySpawn.Add(picked, picked);
            Debug.Log("picked: " + picked);
        }
    }
}
