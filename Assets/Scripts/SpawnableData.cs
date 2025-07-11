using UnityEngine;

[CreateAssetMenu(menuName ="Spawnable Object")]
public class SpawnableData : ScriptableObject
{
    public string name;
    public GameObject prefab;
    public float spawnWeight;
    public int minLayer;
    public int maxLayer;
    public float parallax_xSpeed;
    public float parallax_ySpeed;
}
