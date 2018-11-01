using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 5f;

    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;

    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        
    }
}
	
	// Update is called once per frame
	