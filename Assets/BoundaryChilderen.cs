using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryChilderen : MonoBehaviour
{
    public Boundary b;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float zRot = gameObject.transform.rotation.eulerAngles.z;
        Debug.Log(zRot);
        zRot -= 90;
        b.EnemySplat(zRot, collision.transform.position);
        Destroy(collision.gameObject);

    }
}
