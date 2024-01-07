using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlayerMovement : MonoBehaviour
{
    float speed;
    int dir;
    public GameObject firePrefab;
    Rigidbody2D rb;

    bool faceRight;
    public Transform player;



    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        dir = 0;
        faceRight = true;
        
        rb= GetComponent<Rigidbody2D>();
        player= GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(dir*speed, rb.velocity.y);
        if (faceRight)
        {
            transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x), transform.localScale.y);
        }

        else if (!faceRight)
        {
            transform.localScale = new Vector2((-1) * Mathf.Abs(transform.localScale.x), transform.localScale.y);
        }
    }

    public void Move(string dirStr)
    {
        if (dirStr == "Right")
        {
            dir = 1;
            faceRight = true;
            
        }

        else if (dirStr == "Left")
        {
            dir = -1;
            faceRight = false;
            
        }

        else
        {
            dir = 0;
        }

    }

    public void Fire()
    {
        Instantiate(firePrefab, new Vector3(transform.position.x, transform.position.y + 0.2f, 5), firePrefab.transform.rotation);

    }

    public void Jump()
    {
        if (PlayerMovement.numOfJumps > 0)
        {
            rb.AddForce(new Vector2(0, 150));
            PlayerMovement.numOfJumps--;
        }
    }
}
