using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCage : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var dir = Vector3.Distance(this.player.position, this.transform.position);
        //Debug.Log(dir);

        if(dir <= 12)
        {
            this.gameObject.GetComponent<Cage>().enabled = true;
            this.gameObject.GetComponent<testCage>().enabled = false;
        }
    }
}
