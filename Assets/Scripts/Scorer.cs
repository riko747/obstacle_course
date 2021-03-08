using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumped;

    void Start()
    {
        bumped = 0;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit" && collision.gameObject.tag != "Ground")
        {
            bumped++;
            print("You're bumped " + bumped + " times");
        }
    }
}
