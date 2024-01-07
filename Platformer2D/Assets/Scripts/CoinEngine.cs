using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinEngine : MonoBehaviour
{
    public GameObject[] coinEngine = new GameObject[7];
    public GameObject[] tmp = new GameObject[7];

    public Color[] colors=new Color[4] {Color.red,Color.yellow,Color.blue,Color.green};
    // Start is called before the first frame update
    void Start()
    {
        int j = 0;
        for(int i = 0; i < coinEngine.Length; i++)
        {
            tmp[i]= Instantiate(coinEngine[i],new Vector3(transform.position.x+j,transform.position.y,1),coinEngine[i].transform.rotation);
            tmp[i].GetComponent<SpriteRenderer>().material.color = colors[Random.Range(0,colors.Length)];
            j++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < coinEngine.Length; i++)
        {
            tmp[i].transform.Rotate(0, 3, 0);
        }
    }
}
