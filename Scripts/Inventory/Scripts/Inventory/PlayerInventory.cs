using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    //Here is where we store all the items we collect.
    public InventoryObject inventory;
    
    public void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<GroundItem>();
        if (item)
        {
            inventory.AddItem(new Item (item.item), 1);
            Destroy(other.gameObject);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            inventory.Save();
        }
        if (Input.GetKeyDown(KeyCode.F6))
        {
            inventory.Load();
        }
    }
    // So we dont store the items every time we open the game we need to clear it before we start the new game.
    private void OnApplicationQuit()
    {
        inventory.Container.Items.Clear();
    }
}
