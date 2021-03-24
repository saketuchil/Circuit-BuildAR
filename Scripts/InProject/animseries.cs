using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animseries : MonoBehaviour
{
    public Animator anims;
    // Start is called before the first frame update
    void Start()
    {
        anims=GetComponent<Animator>();
        anims.speed=1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void animser()
    {
        anims.gameObject.GetComponent<Animator>().enabled=true;
        anims.Play("moveseries");
    }
}
