using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_spawn : MonoBehaviour
{
    private bool active;
    private float counter = 0;
    public float time; 
    public GameObject powerPrefab; 
    //public GameObject parent_ufo; 

    // Start is called before the first frame update
    void Start()
    {
        active = true;//boleano 
        //GameObject spawn = Instantiate(powerPrefab, transform.position, Quaternion.identity);//para que aparezca el ovni
       // spawn.transform.parent=parent_ufo.transform; 
       
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            counter = counter + Time.deltaTime;
            if (counter > time) 
            {
                GameObject spawn = Instantiate(powerPrefab, transform.position, Quaternion.identity);
                
                counter = 0;
            }
        }
    }
    public void StopSpawner()//desactivar el spawner
    {
        active = false;
    }
}