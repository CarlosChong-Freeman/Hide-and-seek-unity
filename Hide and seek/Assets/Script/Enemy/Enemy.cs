using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public float viewDistance = 3;
    public float viewAngle = 90;
    public GameObject target;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(target.transform.position, transform.position) <= viewDistance)
        {
            Vector3 dir = target.transform.position - transform.position;
            float angle = Vector3.Angle(dir, transform.forward);
            if (angle <= viewAngle / 2)
            {
                Debug.Log("视野内");
            }
        }
    }
}

    
