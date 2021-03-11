using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KoscOfTruSCR : MonoBehaviour
{
    public float Distance;
    public GameObject ActionText;
    public GameObject tlo;
    public GameObject Cube;
    void Update()
    {
        Distance = PLayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (Distance <= 3)
        {
            ActionText.SetActive(true);
            tlo.SetActive(true); 
        }
        else
        {
            ActionText.SetActive(false); 
            tlo.SetActive(false);
        }
    }
    void OnMouseExit()
    {
        ActionText.SetActive(false);
        tlo.SetActive(false);
    }
}
