using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent nav;
    public GameObject Target;
    public Bounds bounds;

    bool Flag;

    private void Awake()
    {
       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Flag && !nav.hasPath)
        {
            Flag = true;
            RandomPosition();
        }
    }

    void RandomPosition()
    {
        float rx = Random.Range(this.transform.position.x + 5, this.transform.position.x - 5);
        float rz = Random.Range(this.transform.position.z + 5, this.transform.position.z - 5);
        Target.transform.position = new Vector3(rx, Target.transform.position.y, rz);

        //this.transform.LookAt(Target.transform);
        nav.SetDestination(new Vector3(rx, this.transform.position.y, rz));
        Flag = false;
    }
}
