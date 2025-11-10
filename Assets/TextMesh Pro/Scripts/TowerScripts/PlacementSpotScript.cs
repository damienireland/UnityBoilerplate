using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{

    public Tower TowerPrefab; 
  
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Debug.Log("Tower clicked!");
        Instantiate(TowerPrefab, transform.position, transform.rotation);
        Destroy(this.gameObject);
        
    }
}
