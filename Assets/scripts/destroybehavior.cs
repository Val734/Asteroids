using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroybehavior : MonoBehaviour
{
    public GameObject explosionPrefab;
    public void DestroyObject()//se ejecuta cuando uno colisiona con el otro
    {
        if(explosionPrefab!=null)
        {
         //Destroy(collision.gameObject);
            Instantiate/*Creacopias*/(explosionPrefab,transform.position,Quaternion.identity);
        }
        Destroy(gameObject); 
    }

    public void DisableObject()
    {
        if (explosionPrefab != null)
        {
            //Destroy(collision.gameObject);
            Instantiate/*Creacopias*/(explosionPrefab, transform.position, Quaternion.identity);
        }
        gameObject.SetActive(false);
    }
}
