using System;
using System.Collections.Generic;
using UnityEngine;



public class PrisonerController : MonoBehaviour
{
    public Transform target;
    public Animator anim;
    public CharacterController controller;
    public float gravity = 40.0f;

    private void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
        controller = this.gameObject.GetComponent<CharacterController>();
    }

    private void Update()
    {
        if(!controller.isGrounded)
        {
            var dir = new Vector3(this.transform.position.x, -1, this.transform.position.z) * Time.deltaTime * gravity;
            controller.Move(dir);
        }
    }
}