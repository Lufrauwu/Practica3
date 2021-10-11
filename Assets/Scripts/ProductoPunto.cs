using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductoPunto : MonoBehaviour
{
    public float distancia;
    public float ppunto;
    public Color lineColor = Color.white;
    public GameObject cuboEnemigo;
      // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ppunto = Vector3.Dot(transform.right.normalized, cuboEnemigo.transform.right.normalized);
        distancia = Vector3.Distance(cuboEnemigo.transform.position, transform.position);

        Debug.DrawRay(transform.position, transform.right.normalized * 10, lineColor);


        if (distancia <= 12f && ppunto < -0.9f)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

    }
}
