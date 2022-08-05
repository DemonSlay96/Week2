using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public NavMeshAgent Playeragent;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1)) // using mouse as an input
        {
            Ray movePosition = Camera.main.ScreenPointToRay(Input.mousePosition); // used for raycasting
            if(Physics.Raycast(movePosition, out var hitInfo)) // you need this if to dectect and move player by calling movePosition in parameter
            {
                Playeragent.SetDestination(hitInfo.point); // this makes player move towards clicked location
            }
        }
        
    }
}
