using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class series2bulb : MonoBehaviour
{
    public Light animr;
    // Start is called before the first frame update
    void Start()
    {
        animr=GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void seriesbulb()
    {
        animr.range=10;
        animr.intensity+=10;
    }
}
