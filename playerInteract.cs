using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteract : MonoBehaviour {

    public GameObject currentInterObj = null;
    public InterationObject currentInterObjscript = null;
    public Inventory inventory;


    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("interObject"))
        {
            Debug.Log(other.name);
            currentInterObj = other.gameObject;
            currentInterObjscript = currentInterObj.GetComponent<InterationObject>();
        }
        if (currentInterObj)
        {
            //Check to see if this obeject is stored in inventory
            if (currentInterObjscript.inventory)
            {
                inventory.AddItem(currentInterObj);
            }

            //Check to see if this obejct can be opened
            if (currentInterObjscript.openable)
            {
                //Check to see if object is locked
                if (currentInterObjscript.locked)
                {
                    //Check to see if you have object needed to unlock
                    //Search Inventory for the item needed - if found unlock object
                    if (inventory.FindItem(currentInterObjscript.itemNeeded))
                    {
                        // We found the item needed 
                        currentInterObjscript.locked = false;
                        Debug.Log(currentInterObj.name + " was unlocked");
                        //Object is not locked - open the object
                        Debug.Log(currentInterObj.name + " is unlocked");
                        currentInterObjscript.Open();
                    }
                    else
                    {
                        Debug.Log(currentInterObj.name + " was not unlocked");
                    }
                }
            }
        }
    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("interObject"))
        { 
            if(other.gameObject == currentInterObj){
                currentInterObj = null;

            }
        }
    }
}
