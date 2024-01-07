using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    float min;
    float max; 

    float x; //random x Position

    
    public GameObject enemyPrefab;

    public static int amountOfEnemies;
    // Start is called before the first frame update
    void Start()
    {
        min = 32.2f;
        max = 51.9f;
        amountOfEnemies = 5;
        for(int i = 0; i < amountOfEnemies; i++)
        {
            x = Random.Range(min, max);

            Instantiate(enemyPrefab, new Vector3(x, -6.1f, 1), enemyPrefab.transform.rotation);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
