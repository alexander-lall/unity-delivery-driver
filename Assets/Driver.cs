using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 40f;
    [SerializeField] float slowSpeed = 20f;
    [SerializeField] float boostSpeed = 65f;

    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Bumper")
        {
            moveSpeed = slowSpeed;
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveSpeed * moveAmount, 0);
    }
}
