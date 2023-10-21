using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacecraftController : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    public GameObject  BulletPrefab;
    public Transform LaunchOffset;

    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // Get the first touch

            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            // Calculate the direction from the spacecraft to the touch position
            Vector2 direction = (touchPosition - (Vector2)transform.position).normalized;

            // Apply force to move the spacecraft in that direction
            rb.velocity = direction * moveSpeed;
        }
        else
        {
            // Stop the spacecraft if no touch input is detected
            rb.velocity = Vector2.zero;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(BulletPrefab, LaunchOffset.position, transform.rotation);
        }
    }
}

    