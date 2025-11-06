using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{


    public Transform[] waypoints;

    int lane = 2;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Transform GetWaypoint(int i)
    {
        return waypoints[i];
    }

    public Transform GetNextWaypoint()
    {
        int nextIndex = GetNextWaypointIndex();
        return waypoints[nextIndex];
    }

    private int GetNextWaypointIndex()
    {
        index++;
        if (index >= waypoints.Length)
        {
            index = 0;
        }
        return index;
    }
}
