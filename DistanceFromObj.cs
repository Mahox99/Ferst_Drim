using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceFromObj : MonoBehaviour
{
    public GameObject Obj1;
    public GameObject Obj2;
    public static float Dis;
 
    void Update()
    {
        Dis = Vector3.Distance(Obj1.transform.position, Obj2.transform.position);
    }
}
