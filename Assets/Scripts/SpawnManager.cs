using UnityEngine;
using System.Collections.Generic;

public class SpawnManager : MonoBehaviour
{

    public List<Spawnable> spawnables;
    public float spawnInterval;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(spawnRandomObject), 1f, spawnInterval);
    }

    void spawnRandomObject()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
