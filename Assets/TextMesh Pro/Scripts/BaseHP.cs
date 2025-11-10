using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BaseHP : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            
        }
    }

    public int GetHealth()
    {
        return health;
    }
    }

