using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject enemyCommon1;
    public GameObject enemyCommon2;
    public GameObject enemyCommon3;
    public GameObject enemyCommon4;
    public GameObject enemyCommon5;
    public GameObject enemyCommon6;
    public GameObject enemyCommon7;
    public GameObject enemyCommon8;
    public GameObject enemyCommon9;
    public GameObject Boss;
    public float cameraSpeed;

        

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * cameraSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point"))
        {            
                enemyCommon1.SetActive(true);
        }
        if (other.gameObject.CompareTag("Point1"))
        {
            enemyCommon2.SetActive(true);
        }

        if (other.gameObject.CompareTag("Point2"))
        {
            enemyCommon3.SetActive(true);
        }
        if (other.gameObject.CompareTag("Point3"))
        {
            enemyCommon4.SetActive(true);
            enemyCommon5.SetActive(true);

        }
        if (other.gameObject.CompareTag("Point4"))
        {
            enemyCommon6.SetActive(true);
        }
        if (other.gameObject.CompareTag("Point5"))
        {
            enemyCommon8.SetActive(true);
            enemyCommon7.SetActive(true);
        }
        /*
        if (other.gameObject.CompareTag("Point"))
        {
            enemyCommon7.SetActive(true);
        }
        if (other.gameObject.CompareTag("Point"))
        {
            enemyCommon8.SetActive(true);
        }
        if (other.gameObject.CompareTag("Point"))
        {
            enemyCommon9.SetActive(true);
        }

        */

        if (other.gameObject.CompareTag("PointBoss"))
        {
            cameraSpeed = 0;
            Boss.SetActive(true);
        }
    }
}
