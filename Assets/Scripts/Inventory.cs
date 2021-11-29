using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject inventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            inventory.SetActive(false);
        }
    }
    public void OpenInventory()
    {
        inventory.SetActive(true);
    }
    public void CloseInventory()
    {
        inventory.SetActive(false);
    }
  
}
