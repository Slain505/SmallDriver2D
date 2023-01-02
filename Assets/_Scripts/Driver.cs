using System;
using System.Runtime.Serialization;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0.1f;
    [SerializeField] float boostSpeed = 0.3f;
    [SerializeField] float slowSpeed = 0.3f;
    
    void Start()
    {
     Debug.Log("Game start");   
    }

    void FixedUpdate()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveBoosting = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveBoosting, 0);
        transform.Rotate(0, 0, -steerAmount);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Booster")
        {
            moveSpeed = boostSpeed;
            Debug.Log("Boost");
        }

        if (col.gameObject.name == "Bump")
        {
            moveSpeed = slowSpeed;
            Debug.Log("Bump");
        }
    }
}
