using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KoscOfTruSCR : MonoBehaviour
{
    public float Distance;
    public GameObject ActionText;
    public GameObject background;
    public GameObject cube;

    void Update()
    {
        Distance = PLayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (Distance <= 3)
        {
            ActionText.SetActive(true);
            background.SetActive(true); 
        }
        else
        {
            ActionText.SetActive(false); 
            background.SetActive(false);
        }
    }
    void OnMouseExit()
    {
        ActionText.SetActive(false);
        background.SetActive(false);
    }
}
