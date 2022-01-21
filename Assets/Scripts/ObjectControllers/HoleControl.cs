using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleControl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gather"))
        {
            other.transform.parent = null;
            other.GetComponent<BoxCollider>().enabled = false;
        }
        else if (other.CompareTag("MainCube"))
        {
            GameController.GameOver(false);
        }
    }
}
