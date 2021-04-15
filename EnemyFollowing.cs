using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowing : MonoBehaviour
{
    public float Start_Search_Distanse;
    public float Stop_Search_Distanse;
    public float Distance;

    public GameObject[] waypoints;
    public float WPradius;
    int current = 0;

    Transform tr_player;
    float f_rotateSpeed = 3.0f, f_moveSpeed = 3.0f;
    bool search = false;

    void Start()
    {
        tr_player = GameObject.FindGameObjectWithTag("Player").transform;    
    }

    void Update()
    {
        Distance = DistanceFromObj.Dis;
        
        if (Distance <= Start_Search_Distanse)
        {
            search = true;
        }
        else if (Distance >= Stop_Search_Distanse)
        {
            search = false;
        }

        if (search == true)
        {

            //Patrzenie na gracza       //looking for the player
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(
            tr_player.position - transform.position), f_rotateSpeed * Time.deltaTime);

            //ruch w kierunku gracza    //move to player
            transform.position += transform.forward * f_moveSpeed * Time.deltaTime;
        }
        else
        {
            if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
            {
                current++;
                if (current >= waypoints.Length)
                {
                    current = 0;
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * f_moveSpeed);
        }
    }
}
