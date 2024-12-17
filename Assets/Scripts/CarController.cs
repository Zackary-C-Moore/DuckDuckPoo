using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField]
    private float carMovementSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveCameraRight();
    }

    private void moveCameraRight()
    {
        transform.Translate(Vector2.left * carMovementSpeed * Time.deltaTime);
    }
}
