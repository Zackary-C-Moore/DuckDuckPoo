using UnityEngine;

[System.Serializable]
public class Spawnable
{
    public string name;
    public GameObject prefab;
    public float spawnWeight;
    public int minLayer;
    public int maxLayer;
}
