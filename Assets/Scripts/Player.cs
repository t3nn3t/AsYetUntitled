using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //removes perevious forces on the ball right before the strike
    //so that the ball will travel exactly where the user wants it to
    public void Strike(Vector2 force)
    {
        rb.velocity = new Vector2(0, 0);
        rb.AddForce(force);
    }

    public bool IsAiming()
    {
        if (Input.GetMouseButton(0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Vector2 GetPosition()
    {
        return transform.position;
    }
}
//TODO
//slow down time while aiming