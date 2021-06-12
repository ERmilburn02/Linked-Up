using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    Rigidbody rb;
    Vector2 inputV;

    public bool reverseHorizontalInput = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!reverseHorizontalInput)
        {
            inputV.x = Input.GetAxisRaw("Horizontal");
        }
        else
        {
            inputV.x = -(Input.GetAxisRaw("Horizontal"));
        }
        inputV.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector3(inputV.x, 0, inputV.y) * moveSpeed * Time.fixedDeltaTime);
    }
}
