using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopanim : MonoBehaviour
{ 	
	public Animator Animch;
    // Start is called before the first frame update
    void Start()
    {
     	Animch = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void stopmoving()
{
Animch.gameObject.GetComponent<Animator>().enabled = false;
}
}
