using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Stick : MonoBehaviour
{
    public GameObject StickLv1;
    public GameObject Basic_Menu;
    public void OnButtonPressed()
    {
        Debug.Log("Button was pressed!");
        var towerui = GetComponentInParent<TowerUI>();
        var towerref = towerui.towerReference;
        var instance = Instantiate(StickLv1,towerref.transform.position, Quaternion.identity);
        Destroy(Basic_Menu.gameObject);
        Destroy(towerref.gameObject);
        towerui.towerReference = null;
        // Add your desired actions here, e.g., load a scene, change a variable, etc.
    }
}
