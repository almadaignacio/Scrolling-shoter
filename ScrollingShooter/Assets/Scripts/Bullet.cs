using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float velocidad;

    public GameObject Enemy;

    public float Damage;

    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);

        Destroy(gameObject,0.5f);
    }

    private void OnCollisionEnter (Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        if(other.gameObject.CompareTag("Enemy"))
        {
            Instantiate(particle, transform.position, transform.rotation);
            Destroy(gameObject);
           // Destroy(particle, 3);

        }
    }
}
