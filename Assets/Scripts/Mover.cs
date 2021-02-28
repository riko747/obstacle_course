using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //movement coordinates
    [SerializeField]float x, y, z;
    void Start()
    {
       
    }


    void Update()
    {
        transform.Translate(x,y,z);
    }
}
