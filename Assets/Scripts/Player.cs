using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    
    public bool player1 = true;

    public float speed = 10f;

    [Header("Shooting")]
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float firerate = 0.5f;

    public Health health;

    public AudioClip clip;

    private AudioSource source;

    public ParticleSystem boom;

 


    void Start()
    {
        source = GetComponent<AudioSource>();
        InvokeRepeating("Shoot", 0, firerate);
    }

    void Shoot()
    {
        boom.Emit(100);
        source.PlayOneShot(clip);
        source.pitch = Random.Range(2.10f,2.30f);
        Instantiate(bulletPrefab, bulletSpawn.position, transform.rotation);
    }

    void Update()
    {
        var input = new Vector3();
        if (player1)
        {
            input.x = Input.GetAxis("HorizontalKeys");
            input.z = Input.GetAxis("VerticalKeys");
        }
        else
        {
            input.x = Input.GetAxis("HorizontalArrows");
            input.z = Input.GetAxis("VerticalArrows");   
        }
        

        transform.position += input * speed * Time.deltaTime;

        if(input != Vector3.zero)
        {
            transform.forward = input;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            health.TakeDamage(Bullet.damage);
        }
        if (collision.gameObject.CompareTag("health"))
        {
            if (health.TakeDamage(-10))
            {
                Destroy(collision.gameObject);
            } 
        }
    }
}
