using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole_collision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("player");
            

        }
        else if (collision.gameObject.CompareTag("Asteroid"))
        {
            Debug.Log("asteroideee");
        }
    }
}
