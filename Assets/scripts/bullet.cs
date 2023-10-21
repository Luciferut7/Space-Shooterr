using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float Speed = .5f;

    private void Update()
    {
        transform.position += -transform.up * Time.deltaTime * Speed;
    }

   /* void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(gameObject);
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
