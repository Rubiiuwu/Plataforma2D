using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject objectPrefab;
    [SerializeField] float spawnRate = 1;
    [SerializeField] int numberOfObjectsToSpawn = 5;
    
    void Start()
    {
        StartCoroutine("Spawn"/* spawn()*/);
        //StopCorutine("Spawn"/* spawn()*/);
        //StopAllCorutines("Spawn"/* spawn()*/);
    }

    
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        for (int i = 0; i < numberOfObjectsToSpawn; i++)
        {
            Instantiate(objectPrefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
