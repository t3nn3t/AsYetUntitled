using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    public ParticleSystem enemySplat;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void EnemySplat(float xRot, Vector3 pos)
    {
        ParticleSystem temp = Instantiate(enemySplat, pos, Quaternion.Euler(xRot, 90f, 90f));
        temp.Play();
    }
}
