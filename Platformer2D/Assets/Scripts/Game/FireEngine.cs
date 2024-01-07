using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEngine : MonoBehaviour
{
    public Transform playScale;
    bool faceRight;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        playScale = GameObject.Find("Player").transform;
        if (playScale.localScale.x > 0)
        {
            faceRight = true;
        }

        else 
        {
            faceRight = false;
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (faceRight)
        {
            transform.Translate(12*Time.deltaTime,0,0);
        }
        else
        {
            transform.Translate(-12 * Time.deltaTime, 0, 0);

        }




    }
}
