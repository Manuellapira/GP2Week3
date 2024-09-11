using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//meaning it cannot be instantiated
//itis not tangible thing, this class becomes a Super Class
//and well make it our super class Inheritance
public class Animalsound : MonoBehaviour
{
    GameObject[] animal;
    // we will make this virtual function
    //so any classthat will in herit to this can call function
   public virtual void PrintSound()
    {
        Debug.Log("generic sounds");
    }
}
