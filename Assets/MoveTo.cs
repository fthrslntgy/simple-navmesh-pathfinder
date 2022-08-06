using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{

    public Transform goal;
    public NavMeshAgent agent;

    void Start()
    {   
        goal = GameObject.Find("Goal").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) {
            RaycastHit hit;
            
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
                agent.destination = hit.point;
            }
        }
        else
            agent.destination = goal.position;
    }
}
