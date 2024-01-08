using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySOEngine : MonoBehaviour
{
    public EnemySO zorlak;
    SpriteRenderer sr;
    int speed;
    // Start is called before the first frame update
    void Start()
    {
        sr=gameObject.AddComponent<SpriteRenderer>();
        speed=zorlak.speed;
        sr.sprite = zorlak.image;
        gameObject.name = zorlak.enemyName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
