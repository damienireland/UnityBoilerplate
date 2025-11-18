using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public Bullet BulletPrefab;

    public float refreshRate = 5f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("OnTriggerStay");
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null && timer > refreshRate)
        {
            timer = 0f;
            var instance = Instantiate(BulletPrefab, transform.position, transform.rotation);
            instance.SetTarget(enemy);
        }
    }
}
