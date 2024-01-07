using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    string playerDir;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        
    }

    // Update is called once per frame
    void Update()
    {
        playerDir = LeftOrRight();
        MoveToPlayer(playerDir);
    }

    public string LeftOrRight()
    {
        if (PlayerMovement.xPos > transform.position.x)
        {
            return "Right";
        }

        else
        {
            return "Left";
        }
        
    }

    public void MoveToPlayer(string direction)
    {
       
        if (direction == "Right")
        {
            transform.Translate(0.1f*Time.deltaTime*speed, 0, 0);
        }
        else
        {
            transform.Translate(-0.1f*Time.deltaTime*speed,0,0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerFire")
        {
            Destroy(gameObject);
            EnemyManager.amountOfEnemies--;
        }
    }
}
