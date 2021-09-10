using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessing : MonoBehaviour
{
    public PostProcessVolume v;
    private Bloom b;
    private Vignette vg;

    public float BaseBloom = 9f;
    public float BaseVignette = 0f;

    public float AimBloom = 14f;
    public float AimVignette = 0.44f;

    public float transitionSpeed = 0.5f;
    private string state = "base";

    //used so bloom will rach its aim value ast the same time as vignette
    private float bloomScale;

    void Start()
    {
        v.profile.TryGetSettings(out b);
        v.profile.TryGetSettings(out vg);
        vg.active = true;
        b.active = true;

        bloomScale = (AimBloom - BaseBloom) / (AimVignette - BaseVignette);
    }

    void Update()
    {
        if (state == "AimingIn")
        {
            TransIn();
        }
        if (state == "AimingOut")
        {
            TransOut();
        }
    }

    

    private void TransIn()
    {
        if(b.intensity.value<AimBloom)
        {
            b.intensity.value += bloomScale* 0.01f * transitionSpeed;
        }
        if(vg.intensity.value<AimVignette)
        {
            vg.intensity.value += 0.01f * transitionSpeed;

        }
    }

    private void TransOut()
    {
        if (b.intensity.value > BaseBloom)
        {
            b.intensity.value -= bloomScale* 0.005f * transitionSpeed;
        }
        if (vg.intensity.value > BaseVignette)
        {
            vg.intensity.value -= 0.005f * transitionSpeed;
        }
    }


    public void AimIn()
    {
        state = "AimingIn";
    }

    public void AimOut()
    {
        state = "AimingOut";
    }


}
