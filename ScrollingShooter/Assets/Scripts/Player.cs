using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    float movX;
    float movY;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float MovementHorizontal = Input.GetAxis("Horizontal") ;
        float MovementVertical = Input.GetAxis("Vertical");
        Vector3 VectorMovement = new Vector3(MovementHorizontal, MovementVertical, 0f);
        rb.AddForce(VectorMovement * speed * Time.deltaTime);

        //rb.AddForce(new Vector3(movX, movY, 0f) ForceMode.impulse);
    }
}
