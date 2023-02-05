using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] 
    float moveSpeed = 7.5f;

    Vector3 bottomLeft;
    Vector3 topRight;

    // Start is called before the first frame update
    void Start()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(Vector3.zero);
        topRight = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, Camera.main.pixelHeight));
    }

    // Update is called once per frame
    void Update()
    {
        MovePosition();

        RestrictToScreen();
    }

    private void RestrictToScreen()
    {
        float allowedX = Mathf.Clamp(transform.position.x, bottomLeft.x, topRight.x);
        float allowedY = Mathf.Clamp(transform.position.y, bottomLeft.y, topRight.y);

        transform.position = new Vector3(allowedX, allowedY, 0);
    }

    private void MovePosition()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, verticalInput, 0f);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();

        transform.Translate(movementDirection * magnitude * moveSpeed * Time.deltaTime, Space.World);
    }
}
