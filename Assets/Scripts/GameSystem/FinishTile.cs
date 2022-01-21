using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTile : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        GameController.GameOver(true);
    }
}
