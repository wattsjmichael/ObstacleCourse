using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
  [SerializeField] float yValue = 0.00f;
 

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    float xValue = Input.GetAxis("Horizontal");
    float zValue = Input.GetAxis("Vertical");
    transform.Translate(xValue, yValue, zValue);
  }
}
