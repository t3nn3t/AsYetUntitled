using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public AimLine al;
    public Player p;
    public MouseControl mc;
    public TimeController tc;
    public PostProcessing pp;

    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        ManageInputs();
    }


    private void ManageInputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Aiming();
        }
        if (Input.GetMouseButtonUp(0))
        {
            NotAiming();
        }
    }


    private void Aiming()
    {
        al.On();
        tc.SlowDown();
        pp.AimIn();
    }


    private void NotAiming()
    {
        al.Off();
        p.Strike(mc.GetForce());
        tc.ResetTime();
        pp.AimOut();
    }

    

}
