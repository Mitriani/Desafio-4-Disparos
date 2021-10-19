using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject bullet;
    public float startDelay = 0f;
    public float intervalo = 0.5f;
    
    void Start()
    {
        InvokeRepeating("Disparo", startDelay, intervalo);
    }

    void Update()
    {
        
    }

    void Disparo()
    {
        Instantiate(bullet, transform);
    } 
}
