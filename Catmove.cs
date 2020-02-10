using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catmove : MonoBehaviour
{

    public float moveSpeed;
    private Vector3 moveDirection;

    float horizontalMove = 0f;
    // Start is called before the first frame update
    void Start()
    {
        moveDirection = Vector3.down;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");

        moveDirection.x = horizontalMove;

        transform.position += (moveDirection * moveSpeed * Time.deltaTime);
    }

    void FixedUpdate ()
    {
        ///controller.Move(horizontalMove * Time.fixedDeltaTime);

    }
}