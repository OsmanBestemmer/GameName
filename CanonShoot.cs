using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonShoot : MonoBehaviour {
    public GameObject BulletToLeft;
    Vector2 bulletPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;
    public bool canShoot = true;

    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (canShoot == true)
        {
            canShoot = false;
            fire();
            StartCoroutine(Reload());

        }

    }



    IEnumerator Reload()
    {
        if (canShoot == false)
        {
            yield return new WaitForSeconds(1);

            {

                canShoot = true;

            }
        }

    } 

    void fire()
    {
        bulletPos = transform.position;
        
        bulletPos += new Vector2(1.50f, -0.22f);
        Instantiate(BulletToLeft, bulletPos, Quaternion.identity);
        canShoot = false;
        
    }
}
