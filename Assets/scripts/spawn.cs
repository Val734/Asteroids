using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject spawnPrefab;
    public GameObject player;
    private float count=0;
    public float time;
    private Vector3 dir;
    private bool active;
    private int asteroid_counter=0;
    void Start()
    {
        active=true;
        asteroid_counter=0;

    }
    void Update()
    {
        if(active && asteroid_counter<3)
        {
            count=count+Time.deltaTime;
            if (count>time)
            {     
                GameObject spawn=Instantiate(spawnPrefab,transform.position,Quaternion.identity);
                if(player!=null)
                {
                    dir = player.transform.position - transform.position;
                }
                else
                {
                    dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0);
                }
                spawn.GetComponent<asteroid>().SetDirection(dir);
                count=0;    
                asteroid_counter=asteroid_counter+1;   
            }
        }
    }
    public void StopSpawner()
    {
        active=false;
    }
        
    public void StartSpawner()
    {
        active=true;
        asteroid_counter=0;
    }
    
}