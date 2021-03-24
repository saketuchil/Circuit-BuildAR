using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decreaseflows : MonoBehaviour
{
    public Animator animd;
    // Start is called before the first frame update
    void Start()
    {
        animd=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void decreaseflowing()
    {
        animd.speed-=0.1f;
    }
}
