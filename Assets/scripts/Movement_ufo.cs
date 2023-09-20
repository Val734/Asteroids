using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_ufo : MonoBehaviour
{
    public float position;
    private bool dir;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        position=-14.0f;
        transform.position = new Vector3(Random.Range(-14.0f, 14.0f), Random.Range(-10.0f, 7.0f), 0.0f);
        dir = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 14)
        {
            dir=false;
        }
        else if (transform.position.x < -14)

        {
            dir=true;
        }
        if (dir==false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (dir==true)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
