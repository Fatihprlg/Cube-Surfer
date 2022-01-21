using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{


    float horizontalInput;
    float horizontalSpeed = 5;
    float verticalSpeed = 8;
    public static bool gameOver = false;

    void Update()
    {
        if(!gameOver)
            PlayerMovement();
        
    }

    void PlayerMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;
        
        transform.Translate(horizontalInput, 0, verticalSpeed * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2, 2), transform.position.y, transform.position.z);
    }
}
