 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animparallel : MonoBehaviour
{
    public Animator Animp;
    // Start is called before the first frame update
    void Start()
    {
        Animp = GetComponent<Animator>();
        Animp.speed=1f;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Animmove()
    {
        Animp.gameObject.GetComponent<Animator>().enabled = true;
        Animp.Play("moveparalel");
    }
}
