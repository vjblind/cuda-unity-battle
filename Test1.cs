//copy HelloWorldCUDA.dll into Assets/Plugins directory
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Test1 : MonoBehaviour {

    // The imported function
    [DllImport("test", EntryPoint = "TestSort")]
    public static extern void TestSort(int [] a, int length);
 
    public int[] a;
 
    void Start() {
        TestSort(a, a.Length);
    }
}
   



     
 



 
 