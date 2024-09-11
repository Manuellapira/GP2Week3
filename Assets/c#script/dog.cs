using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dog : Animalsound
{
    // Start is called before the first frame update
    void Start()
    {
        PrintSound();
    }

    public override void PrintSound()
    {
        Debug.Log("woof woof");
    }
}
