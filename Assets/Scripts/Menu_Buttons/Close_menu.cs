using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close_menu : MonoBehaviour
{
    public GameObject PlacementSpot;
    public GameObject Basic_Menu;
    public Transform targetObject;

    public void OnButtonPressed()
    {
        Debug.Log("Button was pressed!");
        var instance = Instantiate(PlacementSpot, transform.position, transform.rotation);
        PlacementSpot.transform.position = targetObject.transform.position;
        Destroy(Basic_Menu.gameObject);

        // Add your desired actions here, e.g., load a scene, change a variable, etc.
    }
}
