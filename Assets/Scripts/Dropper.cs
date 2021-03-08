using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float secondsBeforeFall = 3;

    MeshRenderer meshRenderer;
    Rigidbody rigidbody;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > secondsBeforeFall)
        {
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
            
    }
}
