using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private NewControls nc; 
    private MovementBehavior mvb;
    public float SpeedRotation;


    private void Start()
    {
        nc=GetComponent<NewControls>(); 
        mvb=GetComponent<MovementBehavior>();
    }
    void OnEnable()
    {
        Vector3 postrans=Camera.main.ViewportToWorldPoint(new Vector3(0.5f,0.5f,0.0f));
        postrans.z=0;
        transform.position=postrans;
    }

    void Update()
    {

            transform.Rotate(0, 0, nc.moveValue.x*-SpeedRotation);
            mvb.Move(nc.moveValue.y*transform.right);
            
    }
}
