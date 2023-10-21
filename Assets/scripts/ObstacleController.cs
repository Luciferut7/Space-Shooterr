using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController: MonoBehaviour

{
    public float speed = 5.0f; // Set the speed of the obstacle.

    void Start()
    {
        // Randomly spawn the obstacle outside the top of the screen.
        Vector3 spawnPosition = new Vector3(Random.Range(-5f, 5f), 7f, 0f);
        transform.position = spawnPosition;
    }

    void Update()
    {
        // Move the obstacle downward.
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // If the obstacle is below the bottom of the screen, destroy it.
        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }



  private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the object you want to destroy.
        if (collision.gameObject.CompareTag("Destroyable"))
        {
            // Destroy the other object (the one that collided with this object).
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);
        }
    }

  

}

