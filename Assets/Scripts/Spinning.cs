using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{
   [SerializeField] float xRot = 5f;
   [SerializeField] float yRot = 5f;
   [SerializeField] float zRot = 5f;


    // Update is called once per frame
    void Update()
    {
      transform.Rotate(xRot, yRot, zRot);  
    }
}
