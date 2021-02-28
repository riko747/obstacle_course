using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //movement coordinates
    float x, z;

    [SerializeField]float movementSpeed;

    void Start()
    {
       
    }

    void Update()
    {
        Movement();
    }

    //Movement logic
    void Movement()
    {
        Acceleration();
        x = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        z = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        transform.Translate(x, 0, z);
    }

    //Changing speed when left shift is pressed
    void Acceleration()
    {
        float speedChange;

        speedChange = 3;
        if (Input.GetButtonDown("Sprint"))
            movementSpeed += speedChange;
        if (Input.GetButtonUp("Sprint"))
            movementSpeed -= speedChange;
    }
}
