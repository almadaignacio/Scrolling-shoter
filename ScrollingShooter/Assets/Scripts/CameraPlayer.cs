using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    [Header("MovimientoCamara")]
    private Vector3 objetivo;
    [SerializeField] private Camera Camara;
    [SerializeField] private float anguloInicial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objetivo = Camara.ScreenToWorldPoint(Input.mousePosition);

        float anguloRadianes = Mathf.Atan2(objetivo.y - transform.position.y, objetivo.x - transform.position.x);
        float anguloGrados = (180 / Mathf.PI) * anguloRadianes - anguloInicial;
        transform.rotation = Quaternion.Euler(0, 0, anguloGrados);
    }
}
