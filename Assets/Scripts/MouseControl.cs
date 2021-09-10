using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{

    private Vector2 mousePos;
    public Player p;
    
    //gets the current distance between player and the mouse cursor
    private Vector2 GetPlayerDis()
    {
        mousePos = GetMousePos();
        Vector2 playerPos = p.GetPosition();
        Vector2 distanceBetween = new Vector2(playerPos.x-mousePos.x,playerPos.y-mousePos.y);
        return distanceBetween;
    }

    public Vector2 GetForce()
    {
        return (GetPlayerDis()*100);
    }

    public Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
