using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    Vector2 MoveDirection;

    Vector2 mousePosition;

    public Enemy enemy;

    public float HP;
    private float healing;
    public Text textHP;

    public BulletEmeny bulletEnemy;

    // Start is called before the first frame update
    void Start()
    {
        bulletEnemy = GetComponent<BulletEmeny>();
        enemy = GetComponent<Enemy>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float MovementHorizontal = Input.GetAxis("Horizontal");
        float MovementVertical = Input.GetAxis("Vertical");
        Vector3 VectorMovement = new Vector3(MovementHorizontal, MovementVertical, 0f);
        rb.AddForce(VectorMovement * speed * Time.deltaTime);

        textHP.text = "HP: " + HP.ToString("00");

        if (HP <= 0)
        {
            SceneManager.LoadScene(2);
        }


        //rb.AddForce(new Vector3(movX, movY, 0f) ForceMode.impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Heal"))
        {
            for(int i = 1; i < 11; i++)
            {
                HP++;
            }

            Destroy(other.gameObject);

        }
    }

}
