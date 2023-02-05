using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] 
    float moveSpeed = 7.5f;

    Vector2 moveInput;

    Rigidbody2D myRb;

    // Start is called before the first frame update
    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        MovePosition();
    }

    private void GetInput()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
    }

    private void MovePosition()
    {
        myRb.velocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
    }
}
