using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterationObject : MonoBehaviour {

    public bool inventory;      //If true this object can be stored in inventory
    public bool openable;       //If true this can be opened
    public bool locked;         //If true then the object is locked
    public GameObject itemNeeded;       //item needed in order to interact with this item

    //public Animator anim;

    public void DoInteraction()
    {
        // Picked up and put in inventory
        gameObject.SetActive(false);
    }

    public void Open()
    {
        gameObject.SetActive(false);
    }


}
