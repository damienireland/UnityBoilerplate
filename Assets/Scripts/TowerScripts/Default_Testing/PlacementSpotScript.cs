using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{

    //public Tower TowerPrefab;
    public GameObject BasicMenu;
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
        var elem = Instantiate(BasicMenu, canvas.transform);
        // move the menu to be near the tower
        elem.transform.position = transform.position;
        elem.GetComponent<TowerUI>().towerReference =  gameObject;
        GetComponent<CircleCollider2D>().enabled = false;
        
        //Destroy(this.gameObject);
    }
}
