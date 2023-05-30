using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject FireEnemy;
    public Transform SpawnEnemy;
    public float DamageEnemy = 10;
    public float HP = 100;
    public bool InZone;
    public bool Boss;
    private bool Defeated;
    public Transform target;
    public float rotateSpeed = 0.0025f;

    private float TimetbwShots;
    public float startTimeBtwShots;

    public float TimeStart = 0;
    public float TimeEnd = 5;

    public GameObject Explotion1;

    public AudioSource beamEnemy;
    public AudioSource explotionSound;
    // Start is called before the first frame update
    void Start()
    {
        TimetbwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        RotateTowarsTarget();

        if (HP <= 0 && Boss == true)
        {
            Destroy(gameObject);
            Instantiate(Explotion1, transform.position, transform.rotation);
            explotionSound.Play();
            Explotion1.SetActive(true);
            
            TimeStart += Time.deltaTime;
            Debug.Log(Timer());
            Defeated = true;
        }

        if (HP <= 0 && Boss == false)
        {
            gameObject.SetActive(false);
            Explotion1.SetActive(true);
            explotionSound.Play();


        }

        if (TimetbwShots <= 0)
        {
             Instantiate(FireEnemy, transform.position, Quaternion.identity);
            beamEnemy.Play();
            TimetbwShots = startTimeBtwShots;
        }
        else
        {
            TimetbwShots -= Time.deltaTime;
        }

        if(Defeated == true)
        {
            StartCoroutine("Timer");
            SceneManager.LoadScene(3);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            //Debug.Log(HP);
            HP--;
        }
    }

    private void RotateTowarsTarget()
    {
        Vector2 targetDirection = target.position - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x)* Mathf.Rad2Deg - 90f;
        Quaternion q = Quaternion.Euler(new Vector3(0, 0, angle));
        transform.localRotation = Quaternion.Slerp(transform.localRotation, q, rotateSpeed);
    }

     IEnumerator Timer()
    {
        yield return new WaitForSeconds (5);
        Debug.Log("Terminado");
        
    }
}
