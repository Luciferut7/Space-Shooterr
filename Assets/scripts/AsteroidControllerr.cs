using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidControllerr : MonoBehaviour
{
    public GameObject coinPrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(gameObject); // Destroy the asteroid
            SpawnCoin(); // Spawn a coin
        }
    }

    private void SpawnCoin()
    {
        if (coinPrefab != null)
        {
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
        }
    }
}

