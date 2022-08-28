using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraa : MonoBehaviour
{
    public GameObject TARGET;
    public Camera CAM;

    private bool Isvisible(Camera c, GameObject target)
    {
        var planes = GeometryUtility.CalculateFrustumPlanes(c);
        var point = target.transform.position;

        foreach (var plane in planes)
        {
            if (plane.GetDistanceToPoint(point) < 0)
            {
                return false;
            }
        }
        return true;
    }

    private void Update()
    {
        var TargetRender = TARGET.GetComponent<Renderer>();

        if (Isvisible(CAM, TARGET))
        {
            TargetRender.material.SetColor("_Color", Color.red);
        }
        else
        {
            TargetRender.material.SetColor("_Color", Color.black);
        }
    }
}
