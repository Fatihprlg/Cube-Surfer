using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GathererControl : MonoBehaviour
{
    int height;

    [SerializeField] GameObject mainCube;
    GameObject player;

    private void Start()
    {
        player = mainCube.transform.parent.gameObject;
        height = 1;
        //Debug.Log(height);
    }

    private void Update()
    {
        height = mainCube.transform.childCount + 1;
        transform.localPosition = new Vector3(0, -(height * .5f) - 1f, 0);
        transform.localScale = new Vector3(1, height, 1);
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.transform.parent.CompareTag("Player"))
            if (other.CompareTag("Gather"))
            {
                    GatherCube(other.gameObject);
            }
            else if (other.CompareTag("MultipleGather"))
            {

                GatherMultipleCubes(other.gameObject);
            }
        //Debug.Log("heigth = " + height + ", pos = " + transform.localPosition + ", scale = " + transform.localScale);
    }

    void GatherCube(GameObject cube)
    {
        cube.transform.parent = mainCube.transform;
        player.transform.position = new Vector3(player.transform.position.x, height + 2, player.transform.position.z);
        cube.transform.localPosition = new Vector3(0, -height, 0);
    }

    void GatherMultipleCubes(GameObject parentCube)
    {
        parentCube.transform.parent = mainCube.transform;
        parentCube.transform.localPosition = new Vector3(0, -height, 0);
        parentCube.tag = "Gather";
        Transform child;
        int childCount = parentCube.transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            height++;
            child = parentCube.transform.GetChild(0);
            child.parent = mainCube.transform;
            child.tag = "Gather";
            child.transform.localPosition = new Vector3(0, -height, 0);

        }
        player.transform.position = new Vector3(player.transform.position.x, height + 2, player.transform.position.z);
    }

}
