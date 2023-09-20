using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagebehavior : MonoBehaviour
{
    public float damage;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)//se ejecuta cuando uno colisiona con el otro
    {
        collision.gameObject.GetComponent<HealthBehaviourScript>().Hurt(1.0f); 
    }
}
