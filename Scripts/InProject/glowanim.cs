using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glowanim : MonoBehaviour
{
    public Animator Animglow;
    // Start is called before the first frame update
    void Start()
    {
        Animglow = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Animmove()
    {
        Animglow.gameObject.GetComponent<Animator>().enabled = true;
        Animglow.Play("glow");
    }
}



