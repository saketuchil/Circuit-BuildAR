using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animzener : MonoBehaviour
{
    public Animator animz;
    // Start is called before the first frame update
    void Start()
    {
        animz=GetComponent<Animator>();
        animz.speed=1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void animzen()
    {
        animz.gameObject.GetComponent<Animator>().enabled=true;
        animz.Play("movezener");
    }
}
