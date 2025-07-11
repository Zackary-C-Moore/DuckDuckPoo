using UnityEngine;
using System.Collections.Generic;

public class SpawnManager : MonoBehaviour
{

    public List<SpawnableData> spawnables;
    public float spawnInterval;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(spawnRandomObject), 1f, spawnInterval);
    }

    void spawnRandomObject()
    {
        SpawnableData spawnedData = ChooseRandomSpawnable();

        Vector3 position = GetSpawnPosition(spawnedData.minLayer, spawnedData.maxLayer);

        GameObject spawnedObject = Instantiate(spawnedData.prefab, position, Quaternion.identity);


        SpawnableMoveable moveablescript = spawnedObject.GetComponent<SpawnableMoveable>();

        if(moveablescript != null)
        {
            //float speed = moveablescript.
            Debug.Log("Moving Object");
        }
        else
        {
            Debug.Log("Static Object");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    SpawnableData ChooseRandomSpawnable()
    {
        int index = Random.Range(0, spawnables.Count);

        return spawnables[index];
    }

    Vector3 GetSpawnPosition(int minLayer, int maxLayer)
    {
        int layer = Random.Range(minLayer, maxLayer + 1);
        float y = -3f + (layer * 1.5f);
        float x = Camera.main.transform.position.x;

        return new Vector3(x, y, 0f);
    }
}
