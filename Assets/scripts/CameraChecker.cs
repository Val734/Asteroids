using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChecker : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //hay funcion que coje el tranform position y convierte las cordenadas entre 0.0 y 1.1:
        Vector3 postrans=Camera.main.WorldToViewportPoint(transform.position);
        if(postrans.x<-1.5 || postrans.x>1.5 || postrans.y<-1.5 || postrans.y>1.5)
        {
            Destroy(gameObject);
        }
    }
}

