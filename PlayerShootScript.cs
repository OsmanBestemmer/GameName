using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float moveForce = 365f;
    public float maxSpeed = 5f;
    public GameObject Bullet;
    public float jumpForce = 0f;
    public Transform groundCheck;
    public Transform firePoint;
    private bool grounded = false;
    Vector2 bulletPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;
    public bool canShoot = true;
    public bool facingRight = true;
    public bool jump = true;
    private Rigidbody2D rb2d;
    // Use this for initialization

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update()
    {     //Moves Forward and back along z axis                           //Up/Down
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        if(Input.GetButtonDown("Jump")&& grounded)
        {
            jump = true;
        }
        {
            if (canShoot == true)
            {
                if (Input.GetKeyDown("n"))
                {
                    canShoot = false;
                    fire();
                    StartCoroutine(Reload());

                }
            }

        }


    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        if (h * rb2d.velocity.x < maxSpeed)

            rb2d.AddForce(Vector2.right * h * moveForce);
        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
        {
            rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);
        }
        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();

        if (jump)
        {
            rb2d.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }

    }

    // Update is called once per frame




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
        Instantiate(Bullet, firePoint.position, firePoint.rotation);


    }
    void Flip()
    {
        facingRight = !facingRight;

        transform.Rotate(0f, 180f, 0f);
    }
}









