using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gather") ||other.CompareTag("MainCube"))
        {
            GameController.Score  += 1;
            GameController.WriteScoreTxt();
           // Debug.Log("score" + GameController.Score);
            this.gameObject.SetActive(false);
        }
    }
}
