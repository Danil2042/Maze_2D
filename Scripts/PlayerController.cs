using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject Player;
    private Rigidbody2D PlayerRb;
    [SerializeField] Joystick joystick;
    [SerializeField] Collision2D collisionPlayer;
    [SerializeField] float PlayerSpeed;

    private void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float horisontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

        if(horisontal != 0 && vertical != 0)
        {
            PlayerRb.linearVelocity = new Vector2(horisontal * PlayerSpeed, vertical * PlayerSpeed);
        }
        else
        {
            PlayerRb.linearVelocity = Vector2.zero;
        }
        


    }



}
