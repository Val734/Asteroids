using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    public float speed;

    public void Move(Vector3 direction)
    // Start is called before the first frame update
    {
        transform.position +=direction*speed*Time.deltaTime;
    }
}

 
