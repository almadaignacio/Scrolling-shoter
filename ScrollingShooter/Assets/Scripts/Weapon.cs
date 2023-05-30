using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float FireSpeed;
    public GameObject FirePrefab;
    public Transform SpawnPosition;
    public AudioSource Beam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            GameObject newFire  = Instantiate(FirePrefab, SpawnPosition.position, SpawnPosition.rotation);
            Beam.Play();
        }
    }
}
