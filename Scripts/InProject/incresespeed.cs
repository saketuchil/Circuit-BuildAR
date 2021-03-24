using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class incresespeed : MonoBehaviour
{
    public Light animi;
    // Start is called before the first frame update
    void Start()
    {
        animi=GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void  increaseintense()
    {
        animi.range=5;
        animi.intensity+=25;
    }
}
