using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab3_zad3 : MonoBehaviour{
    public float speed = 3f;
    Vector3 pozycja;
    void Start()
    {
        pozycja = transform.position;
    }
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (Vector3.Distance(pozycja, transform.position) >= 10.0f){
            transform.Rotate(Vector3.up, 90.0f);
            pozycja = transform.position;
        }
    }
}