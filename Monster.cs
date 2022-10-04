using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        this.agent = this.gameObject.GetComponent<NavMeshAgent>();
    //    this.agent.destination = target.transform.position;
    //    this.transform.position = this.transform.position - new Vector3(0, this.transform.position.y, 0) + new Vector3(0, this.target.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        agent.Move(target.position * 0.5f * Time.deltaTime);
    }
}
