using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Dragon : MonoBehaviour
{
    public GameObject DragonLv1;
    public GameObject PlacementSpot;
    public GameObject Basic_Menu;
    public void OnButtonPressed()
    {
        Debug.Log("Button was pressed!");
        var tower = GetComponentInParent<TowerUI>().towerReference;
        Destroy(tower);
        Destroy(Basic_Menu.gameObject);
        var instance = Instantiate(DragonLv1, transform.position, transform.rotation);
        // Add your desired actions here, e.g., load a scene, change a variable, etc.
    }
}
