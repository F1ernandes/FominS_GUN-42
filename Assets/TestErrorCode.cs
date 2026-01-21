using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestErrorCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0, iMax = 10; i<iMax; i++)
        {
            Debug.Log(i);
            //Debug.LogWarning("WarNING");
            //Debug.LogError ("Error:" +i % 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
