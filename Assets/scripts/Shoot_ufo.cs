using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_ufo : MonoBehaviour
{
    private GameObject player;
    public GameObject bulletPrefab;
    private float time_elapsed = 0;
    public float time;
    private Vector3 dir;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        time_elapsed = time_elapsed + Time.deltaTime;
        // Instancia la bala del ovni
        if (time_elapsed > time)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            if (player != null)
                dir = player.transform.position - transform.position; 
            else 
                dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0);

            bullet.GetComponent<Bullet_ufo>().SetDirection(dir);
            time_elapsed = 0;
        }

    }
}