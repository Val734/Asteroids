using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class spawn_agujero : MonoBehaviour
{
    private bool active;
    private float counter = 0;
    private float counter2=0; 

    public float time; 

    public float timeOut ;

    public GameObject holePrefab; 
    public UnityEvent OnTimeOut; 
    public UnityEvent OnTime; 

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
            counter2 = counter2 + Time.deltaTime;

            if (counter > time) 
            {
	            Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), Random.Range(-10.0F, 10.0F),0);

                GameObject spawn = Instantiate(holePrefab, position, Quaternion.identity);
                OnTime.Invoke(); 

                counter = 0;
            }
            //timeOut)
            //

            //t.Invoke(); 
            //
            //
            if(timeOut==counter2)
            {
                OnTimeOut.Invoke(); 
                counter2=0;
            }
        }
    }
    public void StopSpawner()//desactivar el spawner
    {
        active = false;
    }
}