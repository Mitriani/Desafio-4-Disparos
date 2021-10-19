using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private float speed = 10f;
    private Vector3 direction = new Vector3(-1,0,0);
    public float bulletLife = 2f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        CambiarScale();
        Destruir();
    }

    void Destruir()
    {
        bulletLife -= Time.deltaTime;
        if (bulletLife < 0)
        {
            Destroy(gameObject);
        }
    }

    void CambiarScale()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale *= 2;
        }
    }
}
