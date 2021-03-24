using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seriesbulbdec : MonoBehaviour
{
    public Light animrc;
    // Start is called before the first frame update
    void Start()
    {
        animrc=GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void seriesdec()
    {
        animrc.intensity-=10;
    }
}
