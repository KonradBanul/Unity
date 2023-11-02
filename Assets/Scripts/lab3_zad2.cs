using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab3_zad2 : MonoBehaviour{
    public float speed = 3.0f;

    private bool movingForward = true;
    private float pozycja;
    private float moveDistance = 10.0f;

    void Start(){
        pozycja = transform.position.x;
    }

    void Update(){
        if (movingForward){
            if (transform.position.x < pozycja + moveDistance){
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
            else{
                movingForward = false;
            }
        }
        else{
            if (transform.position.x > pozycja){
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            else{
                movingForward = true;
            }
        }
    }
}