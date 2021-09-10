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

    void Start()
    {
        v.profile.TryGetSettings(out b);
        v.profile.TryGetSettings(out vg);
        vg.active = true;
        b.active = true;

        BaseEffects();

    }

    public void BaseEffects()
    {

        b.intensity.value = BaseBloom;
        vg.intensity.value = BaseVignette;
    }

    public void AimEffects()
    {
        
        b.intensity.value = AimBloom;
        vg.intensity.value = AimVignette;
    }


}
