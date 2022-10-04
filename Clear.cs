using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Level_Combined"))
        {
            Destroy(GameObject.Find("Level_Combined"));
        }
    }
}
