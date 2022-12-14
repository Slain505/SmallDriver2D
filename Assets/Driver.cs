using System.Runtime.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0.1f;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, 0.1f);
    }
}
