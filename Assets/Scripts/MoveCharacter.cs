using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveCharacter : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public Animator anim;

    ///
    public float currentSpeed;
    void Start()
    {
        //anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        currentSpeed = agent.velocity.magnitude;
        anim.SetFloat("Blend", currentSpeed);
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);

            }

        }
    }
}
