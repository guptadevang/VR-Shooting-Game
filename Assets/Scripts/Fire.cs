using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class Fire : NetworkBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform SpawnPoint;
    [SerializeField] private float BulletSpeed = 20f;

    public void FirBullet()
    {
        GameObject SpawndBullet = Instantiate(bullet, SpawnPoint.position, SpawnPoint.rotation);
        SpawndBullet.GetComponent<Rigidbody>().velocity = SpawnPoint.forward * BulletSpeed;
        Destroy(SpawndBullet, 5f);
    }
}
