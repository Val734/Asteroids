using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    private MovementBehavior mvb;
    private Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {

        mvb=GetComponent<MovementBehavior>();
    }
    // Update is called once per frame
    public void SetDirection(Vector3 d)
    {
        dir=d;
        dir.Normalize();
    }
    void Update()
    {
        mvb.Move(dir);
    }
}


