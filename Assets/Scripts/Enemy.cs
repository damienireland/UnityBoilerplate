using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int health = 25;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("DD1"))
        {
            Destroy(other.gameObject);
            health -= Random.Range(3, 5);
        }
        else if (other.CompareTag("FB1"))
        {
            Destroy(other.gameObject);
            health -= Random.Range(4, 8);
        }
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
 }
