using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;

    [Header("Shooting")]
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float firerate = 0.5f;

    void Start()
    {
        InvokeRepeating("Shoot", 0, firerate);
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, bulletSpawn.position, transform.rotation);
    }

    void Update()
    {
        var input = new Vector3();
        input.x = Input.GetAxis("Horizontal");
        input.z = Input.GetAxis("Vertical");

        transform.position += input * speed * Time.deltaTime;

        if(input != Vector3.zero)
        {
            transform.forward = input;

        }
    }
}
