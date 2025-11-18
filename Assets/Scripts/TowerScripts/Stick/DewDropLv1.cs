using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DewDropLv1 : MonoBehaviour
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
}
