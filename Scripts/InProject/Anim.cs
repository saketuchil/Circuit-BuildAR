using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    public Animator Animc;
    // Start is called before the first frame update
    void Start()
    {
        Animc = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Animmove()
    {
        Animc.gameObject.GetComponent<Animator>().enabled = true;
        Animc.Play("move");
    }
}


