using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] public Transform firePoint;
    [SerializeField] public GameObject bulletPrefab;
    public Pause Pause;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Pause.isPaused != true)
        {
            Shoot();
        }
        
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
