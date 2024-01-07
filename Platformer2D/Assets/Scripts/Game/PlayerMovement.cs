using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    
    //Movement
    float speed;
    float xAxis;
    public static int numOfJumps;
    Rigidbody2D rb;
    bool faceRight;
    //Fire
    public GameObject firePrefab;
   

    //static
    public static float xPos;

    //Animation
    public Animator animControl;
    // Start is called before the first frame update
    void Start()
    {
        faceRight = true;
        rb = GetComponent<Rigidbody2D>();
        speed = 5;
       

        numOfJumps = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
        xPos = transform.position.x;
        Movement();
        Jump();
        Fire();
    }

    void Movement()
    {
        xAxis=Input.GetAxis("Horizontal")*speed * Time.deltaTime;
        Vector2 v=transform.right*xAxis;
        if (Input.GetAxis("Horizontal") < 0)
        {

            faceRight = false;

        }
        else if(Input.GetAxis("Horizontal")>0)
        {
            faceRight = true;

        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            animControl.SetBool("isWalking",true);
        }
        else
        {
            animControl.SetBool("isWalking", false);
        }

        if (faceRight)
        {
            transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x), transform.localScale.y);

        }

        else
        {
            transform.localScale = new Vector2((-1)*Mathf.Abs(transform.localScale.x), transform.localScale.y);
        }


        transform.Translate(v);
        
    }

    public void Fire()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            
            Instantiate(firePrefab, new Vector3(transform.position.x, transform.position.y + 0.2f, 5), firePrefab.transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            float y = 0;
            for(int i = 0; i < 3; i++)
            {
                Instantiate(firePrefab, new Vector3(transform.position.x, transform.position.y+y, 5), firePrefab.transform.rotation);
                y += 0.2f;
            }
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&numOfJumps>0)
        {
            rb.AddForce(new Vector2(0, 150));
            animControl.SetBool("IsJumping", true);
            numOfJumps--;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            animControl.SetBool("IsJumping", false);

            numOfJumps = 2;
        }
    }
}
