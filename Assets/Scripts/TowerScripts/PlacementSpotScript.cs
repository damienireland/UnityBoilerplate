using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{

    //public Tower TowerPrefab;
    public GameObject BlockPrefab;
    public Tower TowerPrefab;
    private Canvas canvas;

    void Start()
    {
        canvas = FindObjectOfType<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        // todo raycast from camera to scenario and check if it is a tower

        //var instance = Instantiate(TowerPrefab, transform.position, transform.rotation);
        // Destroy(this.gameObject);
        //Debug.Log("Tower clicked!");

        
        var elem = Instantiate(BlockPrefab, canvas.transform);
        // move the menu to be near the tower
        elem.transform.position = transform.position;


    }
}
