using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float speed = 40;
    public GameObject bullet;
    public Transform barrel;


    public void Fire()
    {
        GameObject spawnedbullet = Instantiate(bullet, barrel.position, barrel.rotation);
        spawnedbullet.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
        Destroy(spawnedbullet, 2);
    }
}
