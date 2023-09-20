using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_ufo : MonoBehaviour
{
    private MovementBehavior mvb; 
    private Vector3 dir; 
    // Start is called before the first frame update
    void Start()
    {
        mvb = GetComponent<MovementBehavior>(); 
    }
    public void SetDirection(Vector3 d)
    {
        dir =d; 
        dir.Normalize(); 
    }
    // Update is called once per frame
    void Update()
    {
        mvb.Move(dir);
    }
}




































