using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    private LineRenderer lineRend;

    public Rigidbody2D rb;

    private bool ghosting = true;
    public float foresight = 0.2f;

    void Start()
    {
        lineRend = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ghosting)
        {
            StartGhosting();
        }
    }

    private void StartGhosting()
    {
        Vector2 ghostDistance = GetGhostDistance();
        lineRend.enabled = true;
        Vector2 sp = enemy.transform.localPosition;
        Vector2 ep = new Vector2(sp.x + (ghostDistance.x * foresight), sp.y + (ghostDistance.y * foresight));
        lineRend.SetPosition(0, sp);
        lineRend.SetPosition(1, ep);
    }


    private Vector2 GetGhostDistance()
    {
        Vector2 dist = rb.velocity;
        return dist;
    }
}

//change from ghost to a line renderer using ghost pos as its end point to convey the speed
