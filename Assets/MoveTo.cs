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
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            agent.destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        else
            agent.destination = goal.position;
    }
}
