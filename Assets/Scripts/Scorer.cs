using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Scorer : MonoBehaviour
{
  public TextMeshProUGUI bumpsText;
  public TextMeshProUGUI easterText;
  public TextMeshProUGUI finishText;
  int bumps = 0;

  void Start()
  {
    SetBumpText();
  }


  void SetBumpText()
  {
    bumpsText.text = "Total Bumps " + bumps.ToString();
  }
  private IEnumerator OnCollisionEnter(Collision other)
  {
    if (other.gameObject.tag != "Obstacle")
    {
      bumps++;
      //Debug.Log("You have bumped into a thing this many times: " + bumps);
      SetBumpText();
    }
    if (bumps == 30)
    {
      easterText.text = "Ummm... You hit them all!";
    }
    
    if (other.gameObject.tag == "Finish" & bumps >= 3)
    {
      finishText.text = "Great job! Darn Near Perfect!";
      yield return new WaitForSeconds(2);
      SceneManager.LoadScene(0);
     
    }
  }

}
