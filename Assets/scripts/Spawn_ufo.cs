using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_ufo : MonoBehaviour
{
    private bool active;
    private float counter = 0;
    public float time; 
    public GameObject ufo1Prefab; 

    // Start is called before the first frame update
    void Start()
    {
        active = true;//boleano 
        GameObject spawn = Instantiate(ufo1Prefab, transform.position, Quaternion.identity);//para que aparezca el ovni
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            counter = counter + Time.deltaTime;
            if (counter > time)
            {
                GameObject spawn = Instantiate(ufo1Prefab, transform.position, Quaternion.identity);
                counter = 0;
            }
        }
    }
    public void StopSpawner()//desactivar el spawner
    {
        active = false;
    }
}