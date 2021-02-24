using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

  private void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.tag == "Player")
    {
      GetComponent<MeshRenderer>().material.color = new Color(255f, 161f, 0f);
      gameObject.tag = "Obstacle";
      
    }
  }
}
