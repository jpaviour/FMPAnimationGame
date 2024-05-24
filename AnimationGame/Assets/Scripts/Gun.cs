using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawn;
    public GameObject bulletPrefab;
    public float bulletSpeed = 1;
    public AudioSource gunshot;

    private void Start()
    {
        gunshot= GetComponent<AudioSource>();
    }
    public void Shoot()
    {

        var bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        // Rotate the bullet 90 degrees on the z-axis
        bullet.transform.Rotate(90, 0, 0);

        bullet.GetComponent<Rigidbody>().velocity = bulletSpawn.forward * bulletSpeed;

        gunshot.Play();
    }
}
