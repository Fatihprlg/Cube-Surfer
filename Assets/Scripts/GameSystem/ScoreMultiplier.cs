using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreMultiplier : MonoBehaviour
{

    [SerializeField]
    int Multiplier;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gather"))
        {
            MultiplyScore(other);
        }
        else if (other.CompareTag("MainCube"))
        {
            GameController.GameOver(true);
            //Debug.Log("Over, Score = " + GameController.Score);
        }

    }

    void MultiplyScore(Collider other)
    {
        GameController.Score *= Multiplier;
        other.transform.parent = null;
        other.GetComponent<BoxCollider>().enabled = false;
        GetComponent<BoxCollider>().isTrigger = false;
        GameController.WriteScoreTxt();
    }

    
}
