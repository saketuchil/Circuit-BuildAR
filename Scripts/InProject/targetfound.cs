using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetfound : MonoBehaviour
{
    public GameObject circuit;
    // Start is called before the first frame update
    void Start()
    {
        circuit=GetComponent<GameObject>();
        //circuit.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onfound()
    {
        circuit.gameObject.SetActive(true);
    }
    public void onlost()
    {
        circuit.gameObject.SetActive(false);
    }
}
