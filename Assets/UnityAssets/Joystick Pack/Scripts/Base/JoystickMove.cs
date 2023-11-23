using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMove : MonoBehaviour
{
    // Joystick���� Player �����̱�
    public Joystick moveJoystick;
    public float playerSpeed;
    private Rigidbody playerRb;
    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (moveJoystick.Direction.y != 0)
        {
            //velocity - �ӵ�
            playerRb.velocity = new Vector3(-moveJoystick.Direction.x * playerSpeed, 0, -moveJoystick.Direction.y * playerSpeed);
        }
        else
        {
            playerRb.velocity = Vector3.zero;
        }
    }
}