using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15f;

    public float lifeTime = 2f;

    public static int damage = 10;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }


    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);   
    }
}
