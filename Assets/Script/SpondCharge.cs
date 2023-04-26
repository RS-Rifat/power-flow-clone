using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpondCharge : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    private void Start()
    {
        StartCoroutine(WaitForShoot());
    }

    private IEnumerator WaitForShoot()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        yield return new WaitForSeconds(.7f);
        StartCoroutine(WaitForShoot());
    }
}
