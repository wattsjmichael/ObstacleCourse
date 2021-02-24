using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumps = 0;
      private void OnCollisionEnter(Collision other)
  {
    if(other.gameObject.tag != "Obstacle") 
    {
    bumps ++;
    Debug.Log("You have bumped into a thing this many times: " + bumps);
    }
  }

}
