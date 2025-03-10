using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class atrray : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] a;
    void Start()
    {
        printAll(a);
    }

    void printAll(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Debug.Log(a[i]);
        }
    }

    int getFirst(int[] a)
    {
        return a[0];
    }

    int getLast(int[] a)
    {
        return a[a.Length-1];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
