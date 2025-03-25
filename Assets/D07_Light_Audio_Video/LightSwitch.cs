using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject LampOn;
    public GameObject LampOff;
    int state = -1;
    private void Start()
    {
        LampOn.SetActive(false);
        LampOff.SetActive(false);
    }
    private void OnMouseDown()
    {
        state *= -1;
        print("MouseDown!!");
        if (state == -1)
        {
            LampOn.SetActive(false);
            LampOff.SetActive(true);
        }
        else
        {
            LampOn.SetActive(true);
            LampOff.SetActive(false);
        }
    }


}
