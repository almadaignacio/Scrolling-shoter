using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float FireSpeed;
    public GameObject FirePrefab;
    public Transform SpawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("Shoot");

            GameObject newFire  = Instantiate(FirePrefab, transform.position, transform.rotation);

            Rigidbody rb = newFire.GetComponent<Rigidbody>();

            rb.AddForce(Vector2.right * FireSpeed, ForceMode.Impulse);

            //newFire.GetComponent<Rigidbody>().AddRelativeForce(Vector3 2); 
        }
    }

    
}
