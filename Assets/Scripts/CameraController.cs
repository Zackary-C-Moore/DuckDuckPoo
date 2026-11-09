using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float cameraMovementSpeed;
    [SerializeField]
    private float minY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveCameraRight();
    }

    void LateUpdate()
    {
        minHeightCheck();
    }

    private void moveCameraRight()
    {
        transform.Translate(Vector2.right * cameraMovementSpeed * Time.deltaTime);
    }

        //=================================================================
    //This will be used to dictate how low the player can fly
    //=================================================================
    private void minHeightCheck()
    {
        //if(transform.position.y < minY)
        //{
            Vector3 pos = transform.position;
            pos.y = Mathf.Max(pos.y, minY);
            transform.position = pos;
        //}
    }
}
