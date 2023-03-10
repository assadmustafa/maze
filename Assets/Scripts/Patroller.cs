using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    private Animator mAnimator;

    public Transform[] waypoints;
    public int speed;
    private int waypointIndex;
    private float dist;

    void Start()
    {
        mAnimator = GetComponent<Animator>();

        waypointIndex = 0;
        transform.LookAt(waypoints[waypointIndex].position);
    }

    void Update()
    {
        dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if (dist < 1f)
        {
            IncreaseIndex();
            mAnimator.SetTrigger("walking");

        }
        Patrol();
    }

    void Patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void IncreaseIndex()
    {
        waypointIndex++;
        if (waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
        transform.LookAt(waypoints[waypointIndex].position);
    }
}
