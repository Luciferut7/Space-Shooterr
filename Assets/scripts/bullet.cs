using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float Speed = .5f;

    private void Update()
    {
        transform.position += -transform.up * Time.deltaTime * Speed; // this help to make bullet release a equal interval of time
    }

   /* void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(gameObject);
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Asteroid")) // the bullet will destroy when it will hit the asteroid
        {
            
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
