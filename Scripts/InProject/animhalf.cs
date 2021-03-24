using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animhalf : MonoBehaviour
{
    public Animator animh;
    // Start is called before the first frame update
    void Start()
    {
        animh=GetComponent<Animator>();
        animh.speed=1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void animhal()
    {
        animh.gameObject.GetComponent<Animator>().enabled=true;
        animh.Play("moveHalf");
    }
}
