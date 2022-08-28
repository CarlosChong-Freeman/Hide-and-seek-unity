using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public float Distance;
    public LayerMask layer;
    public Vector3 Direction;

    public GameObject Enemy;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 360; i ++)
            {
                Enemy.transform.Rotate(Direction);

                if (Physics.Raycast(transform.position, Vector3.forward, Distance, layer))
                {
                    Debug.Log("True " + i);
                }
            }
        }
    }
}