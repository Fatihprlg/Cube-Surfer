using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleControl : MonoBehaviour
{
    BoxCollider obstacleCollider;

    private void Start()
    {
        obstacleCollider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gather"))
        {
            other.transform.parent = null;
            other.GetComponent<BoxCollider>().enabled = false;
            obstacleCollider.isTrigger = false;
        }
        if (other.CompareTag("MainCube"))
        {
            GameController.GameOver(false);
        }
    }


}
