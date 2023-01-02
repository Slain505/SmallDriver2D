using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] private float delayOnDestroy = 0.5f;
    [SerializeField] private Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] private Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private bool hasPackage = false;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Hit");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            _spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, delayOnDestroy);
            Debug.Log("Package picked up!");
        }

        if (other.tag == "Customer" && hasPackage)
        {
            _spriteRenderer.color = noPackageColor;
            hasPackage = false;
            Debug.Log("Delivered!");
        }
    }
}
