using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour
{
    [SerializeField] float fallTimer = 3f;
    MeshRenderer renderer;
    Rigidbody gravity;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        gravity = GetComponent<Rigidbody>();

        renderer.enabled = false;
        gravity.useGravity = false;

        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Time.time >= fallTimer)
        {
            renderer.enabled = true;
            gravity.useGravity = true;
        }
    }
}
