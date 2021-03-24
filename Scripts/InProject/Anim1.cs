using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim1 : MonoBehaviour
{
    public Animator Animc1;
    // Start is called before the first frame update
    void Start()
    {
        Animc1 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Animmove()
    {
        Animc1.gameObject.GetComponent<Animator>().enabled = true;
        Animc1.Play("move1");
    }
}
