using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private GameObject followPoint;
    void LateUpdate()
    {
        transform.position = followPoint.transform.position + new Vector3(0,0,-10);
    }
}
