using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
  float moveSpeed = 10f;
 

  // Start is called before the first frame update
  void Start()
  {
    Instructions();
  }

  // Update is called once per frame
  void Update()
  {
    Movement();
  }


  void Instructions()
  {
    Debug.Log("Welcome to my game! Cheers!");
    Debug.Log("Using the the WASD keys, move around Steven");
    Debug.Log("Dont hit the walls! Good Luck!");
  }

  void Movement()
  {
    float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
    float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
    transform.Translate(xValue, 0, zValue);
  }
}
