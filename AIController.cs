using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
 {
 
     public Transform Player;
     int MoveSpeed = 4;
     int MaxDist = 2;
     int MinDist = 1;
 
 
     void Start()
     {
 
     }
 
     void Update()
     {
         transform.LookAt(Player);
 
         if (Vector3.Distance(transform.position, Player.position) >= MinDist)
         {
 
             transform.position += transform.forward * MoveSpeed * Time.deltaTime;
 
 
 
             if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
             {
                 //Here Call any function U want Like Shoot at here or something
             }
 
         }
     }
 }