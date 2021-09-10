using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimLine : MonoBehaviour
{
    private LineRenderer lineRend;
    public MouseControl mc;
    public Player p;
    private bool aiming = false;

    void Start()
    {
        lineRend = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (aiming)
        {
            Aiming();
        }
    }

    private void Aiming()
    {
        Vector2 sp = p.GetPosition();
        Vector2 MouseP = mc.GetMousePos();
        Vector2 ep = new Vector2(sp.x + (sp.x - MouseP.x), sp.y + (sp.y - MouseP.y));
        lineRend.SetPosition(0, sp);
        lineRend.SetPosition(1, ep);
    }
    


    public void Off()
    {
        aiming = false;
        lineRend.enabled = false;
    }

    public void On()
    {
        aiming = true;
        lineRend.enabled = true;
    }
}
//change aiming calls from being called in update to being called in player script
//then change postprocessing script so baseeffects arent constantly called