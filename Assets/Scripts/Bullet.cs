using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15f;

    public float lifeTime = 2f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }


    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
