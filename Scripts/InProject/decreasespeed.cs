using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decreasespeed : MonoBehaviour
{
    public Light animd;
    // Start is called before the first frame update
    void Start()
    {
        animd=GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void decrease()
    {
        animd.intensity-=25;
    }
}
