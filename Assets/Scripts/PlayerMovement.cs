﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    Rigidbody rb;
    Vector2 inputV;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        inputV.x = Input.GetAxisRaw("Horizontal");
        inputV.y = Input.GetAxisRaw("Vertical");
        if (transform.position.y < 0f)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector3(inputV.x, 0, inputV.y) * moveSpeed * Time.fixedDeltaTime);
    }
}
