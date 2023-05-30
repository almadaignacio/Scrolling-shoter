using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class BulletEmeny : MonoBehaviour
{
    public float Damage;

    public float speed;

    private Transform Playerposition;
    private Vector2 target;

    public Player player;

    public GameObject particleEnemy;

    // Start is called before the first frame update
    void Start()
    {
        //player = GetComponent<Player>();
        player = GameObject.Find("Player").GetComponent<Player>();
        
        Playerposition = GameObject.FindGameObjectWithTag("Player").transform;
        
        target = new Vector2 (Playerposition.position.x, Playerposition.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            Destroy(gameObject);
        }

        Destroy(gameObject, 1f);
    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Player"))
        {
            player.HP--;
            //Debug.Log("HP player: " + player.HP);
            Instantiate(particleEnemy, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
