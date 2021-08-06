using UnityEngine;
using System.Collections;
 
public class EnemyAI : MonoBehaviour
{
    public Transform[] Waypoints;
    public float Speed;
    public int curWayPoint;
    public bool doPatrol = true;
    public Vector3 Target;
    public Vector3 MoveDirection;
    public Vector3 Velocity;
 
    private UnityEngine.AI.NavMeshAgent agent;
 
 
    void OnTriggerEnter(){
        agent.SetDestination (Target);
        }
 
    void Update()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.SetDestination (Target);
        {
            agent.SetDestination (Target);
        }
 
        if (curWayPoint < Waypoints.Length)
        {
            Target = Waypoints[curWayPoint].position;
            MoveDirection = Target - transform.position;
            Velocity = GetComponent<Rigidbody>().velocity;
 
            if(MoveDirection.magnitude < 1)
            {
                curWayPoint++;
            }
            else
            {
                Velocity = MoveDirection.normalized * Speed;
            }
        }
        else
        {
            if(doPatrol)
            {
                curWayPoint=0;
            }
            else
            {
                Velocity = Vector3.zero;
            }
        }
        GetComponent<Rigidbody>().velocity = Velocity;
        transform.LookAt (Target);
    }
 
}