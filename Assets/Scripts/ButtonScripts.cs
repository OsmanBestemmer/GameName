using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScripts : MonoBehaviour
{
    public GameObject objectToEnable;
 
   
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Ball")) //Tjekker om mit gameobject rammer "Player"
        {
            objectToEnable.GetComponent<UpAndDown>().enabled = true;
        }
    } 
}
