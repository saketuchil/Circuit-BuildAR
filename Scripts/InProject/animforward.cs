using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animforward : MonoBehaviour
{
    public Animator animf;
    // Start is called before the first frame update
    void Start()
    {
        animf=GetComponent<Animator>();
        animf.speed=1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void animfor()
    {
        animf.gameObject.GetComponent<Animator>().enabled=true;
        animf.Play("moveforward");
    }
}
