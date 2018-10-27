using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToDeactivate;

    [SerializeField]
    private string objectTagName;

    [SerializeField]
    private string
    objectName;
    [SerializeField]
    private bool Activate = false;


    void Awake()
    {
        objectToDeactivate.SetActive(false);
    }

    private void Start()
    {
        if (Activate)
        {
            objectToDeactivate = gameObject;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.CompareTag(objectTagName) || collision.gameObject.name == objectName) && !Activate)
        {
            objectToDeactivate.SetActive(false);
        }
        /*    if (!Activate)
            {
                objectToDeactivate.SetActive(true);
            }
        */
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag(objectTagName) || collider.gameObject.name == objectName)
        {
            objectToDeactivate.SetActive(false);
        }
        if (!Activate)
        {
            objectToDeactivate.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Activate = !Activate;
    }
}