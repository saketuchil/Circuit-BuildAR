using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseflows : MonoBehaviour
{
    public Animator anims;
    //public float animSpeed=1f;
    // Start is called before the first frame update
    void Start()
    {
        anims=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void increaseflowing()
    {
        anims.speed+=0.1f;
    }
}
