using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public Path path;
    public int waypointIndex = 0;
    Transform position;
    public int health = 20;
    public float speed = 2f;
    public int reward = 5;
    public int damage = 9;

    public GameObject firstpathStart;

    public GameObject secondpathStart;

    public GameObject thirdpathStart;
    private void Awake()
    {
        position = GetComponent<Transform>();
    }

    // Start is called before the first frame update
    private void Start()
    {
       Debug.Log("Enemy spawned");
        if (position.position.y >= -18f && position.position.y < -17f)
        {
            path = GameObject.Find("Path1Waypoints").GetComponent<Path>();
        }
        else if (position.position.y >= -19f && position.position.y < -18f)
        {
            path = GameObject.Find("Path2Waypoints").GetComponent<Path>();
        }
        else if (position.position.y >= -20f && position.position.y < -19f)
        {
            path = GameObject.Find("Path3Waypoints").GetComponent<Path>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform targetWaypoint = path.GetWaypoint(waypointIndex);
        Vector3 distance = targetWaypoint.position - position.position;
        if (distance.magnitude < 0.1f)
        {
            waypointIndex++;
            if (waypointIndex >= path.waypoints.Length)
            {
                targetWaypoint.GetComponent<BaseHP>().TakeDamage(damage);
                Destroy (gameObject);
            }
        }
        else
        {
            Vector3 direction = distance.normalized;
            
            position.position += direction * speed * Time.deltaTime;
        }
    }
}
