using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float FireSpeed;
    public GameObject FirePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            GameObject newFire  = Instantiate(FirePrefab, transform.position, transform.rotation);
            //newFire.GetComponent<Rigidbody>().AddRelativeForce(Vector3 2); 
        }
    }
}
