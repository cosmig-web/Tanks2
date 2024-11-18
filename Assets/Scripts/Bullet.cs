using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15f;

    public float lifeTime = 2f;

    public static int damage = 10;

    public GameObject explosionPrefab;

    void Start()
    {
        Invoke("SelfDestruct", lifeTime);
    }


    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        SelfDestruct();  
    }

    void SelfDestruct()
    {

        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
