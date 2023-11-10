using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject Player;

    public Transform startPoint; 
    public Transform endPoint; 
    public float speed = 2.0f;
    public bool playerOnPlatform = false;

    private Vector3 nextPosition;

    void Start()
    {
        nextPosition = endPoint.position;
    }

    void Update()
    {
        if (playerOnPlatform)
        {
            transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, nextPosition) < 0.1f)
            {
                ToggleDestination();
            }
        }
    }

    void ToggleDestination()
    {
        nextPosition = nextPosition == startPoint.position ? endPoint.position : startPoint.position;
    }

private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Debug.Log("Player wszedł na windę.");
            playerOnPlatform = true;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            Debug.Log("Player zszedł z windy.");
            playerOnPlatform = false;
        }
    }
}