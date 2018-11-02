using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public GameObject[] inventory = new GameObject[10];


    public void AddItem(GameObject item)
    {
        bool itemAdded = false;

        //Find the first open slot in the inventory
        for(int i = 0; i < inventory.Length; i++)
        {
            if(inventory[i] == null)
            {
                inventory[i] = item;
                Debug.Log(item.name + " was added");
                itemAdded = true;
                item.SendMessage("DoInteraction");
                break;
            }
        }

        //inventory full
        if (!itemAdded)
        {
            Debug.Log("Inventory is full - Item not added");
        }
    }

    public bool FindItem(GameObject item)
    {
        for(int i = 0; i < inventory.Length; i++)
        {
            if(inventory[i] == item)
            {
                //We found the item
                return true;
            }
        }
        //Item not found
        return false;
    }

}
