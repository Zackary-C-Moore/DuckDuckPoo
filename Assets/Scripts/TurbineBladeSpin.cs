using UnityEngine;

public class TurbineBladeSpin : MonoBehaviour
{
    public float rotationSpeed = 180f;
    private SpriteRenderer spriteRenderer;
    public int frontBladeSortingLayer = 20;
    public int backBladeSortingLayer = 18;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rotateBlades();
        adjustBladeOrderLayer();
    }

    private void rotateBlades()
    {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }

    private void adjustBladeOrderLayer()
    {
        float angle = transform.eulerAngles.z % 360f;

        if (angle >= 200f || angle <= 40f)
        {
            spriteRenderer.sortingOrder = frontBladeSortingLayer;
        }
        else
        {
            spriteRenderer.sortingOrder = backBladeSortingLayer;
        }
    }
}
