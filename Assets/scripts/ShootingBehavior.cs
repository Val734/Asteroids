using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehavior : MonoBehaviour
{
    public GameObject bulletPrefab; 



    //private int directions; 
    //void Start()
    //{
    //    directions=0; 
    //}
    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bullet.GetComponent<bullet>().SetDirection(transform.right);
    }

    public void Shoot2()
    {
        Vector3[] directions = { Vector3.right, Vector3.up, Vector3.left, Vector3.down };

        foreach (Vector3 direction in directions)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.GetComponent<bullet>().SetDirection(direction);
        }
    }
}
