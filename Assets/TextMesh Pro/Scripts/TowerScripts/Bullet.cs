using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Enemy Target;
    public float speed = 5f;

    public void SetTarget(Enemy target)
    {
        Target = target;
    }

    void Update()
    {
        if (Target == null)
        {
            Destroy(gameObject);
            return;
        }
        var delta = Target.transform.position - transform.position;
        var direction = delta.normalized;
        transform.position += direction * speed * Time.deltaTime;

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

}
