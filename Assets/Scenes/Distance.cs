using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    [SerializeField] Transform point;
    [SerializeField] Text distanceText;

    float distance;



    // Update is called once per frame
    void Update()
    {
        distance=(point.transform.position - transform.position).magnitude;
        distanceText.text= distance.ToString("F3") + "";
    }
}
