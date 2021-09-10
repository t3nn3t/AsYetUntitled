using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimLine : MonoBehaviour
{
    private LineRenderer lineRend;
    public MouseControl mc;
    public Player p;
    public TimeController tc;
    public PostProcessing pp;

    void Start()
    {
        lineRend = GetComponent<LineRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(p.IsAiming())
        {
            AimingCalls();
        }
        else
        {
            AimingClose();
        }
        
    }

    private void AimingCalls()
    {
        UpdatePoints();
        tc.SlowDown();
        pp.AimEffects();
    }

    private void AimingClose()
    {
        lineRend.enabled = false;
        tc.ResetTime();
        pp.BaseEffects();
    }

    private void UpdatePoints()
    {

        lineRend.enabled = true;
        Vector2 sp = p.GetPosition();
        Vector2 MouseP = mc.GetMousePos();
        Vector2 ep = new Vector2(sp.x + (sp.x - MouseP.x), sp.y + (sp.y - MouseP.y));
        lineRend.SetPosition(0, sp);
        lineRend.SetPosition(1, ep);
    }
}
