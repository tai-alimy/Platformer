using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemySO", menuName = "EnemySO")]
public class EnemySO : ScriptableObject
{
    public string enemyName;
    public int speed;
    public int life;
    public Sprite image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
