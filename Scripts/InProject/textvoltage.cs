using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textvoltage : MonoBehaviour
{
    public Light l;
    public Text voltext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changetext()
    {
        if(l.intensity<=1)
        {
            voltext.text="1V";
        }
        else if(l.intensity<=26)
        {
            voltext.text="2V";
        }
        else if(l.intensity<=51)
        {
            voltext.text="3V";
        }
        else if(l.intensity<=76)
        {
            voltext.text="4V";
        }
        else if(l.intensity<=101)
        {
            voltext.text="5V";
        }
        else if(l.intensity<=126)
        {
            voltext.text="6V";
        }
        else if(l.intensity<=151)
        {
            voltext.text="7V";
        }
        else if(l.intensity<=176)
        {
            voltext.text="8V";
        }
        else if(l.intensity<=201)
        {
            voltext.text="10V";
        }
    }
}
