using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intensitystop : MonoBehaviour
{
    public Light l;
    public Animator animstop;
    // Start is called before the first frame update
    void Start()
    {
        l=GetComponent<Light>();
        animstop=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onfound()
    {
        l.intensity=1;
    }
    public void intensestop()
    {
        if(l.intensity>=200)
        {
            animstop.gameObject.GetComponent<Animator>().enabled=true;
            animstop.Play("stopglowing");
        } 
    }
}
