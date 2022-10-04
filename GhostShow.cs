using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostShow : MonoBehaviour
{
    private float time;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 3.0f)
        {
            this.transform.LookAt(new Vector3(Random.Range(-13.201f, 10.470f), this.transform.position.y, this.transform.position.z));

            time = 0.0f;
        }

    }
}
