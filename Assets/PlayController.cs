using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    public Rigidbody playRigidbody;
    public float speed = 8f;
    void Start()
    {
        playRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 8f, zSpeed);
        playRigidbody.velocity = newVelocity;


    }
    public void die()
    {
        gameObject.SetActive(false);
    }
}