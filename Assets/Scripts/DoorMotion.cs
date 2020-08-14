﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    public Animator animator;
    public bool isOpen;
    //public GameObject door_axis;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            animator.SetTrigger("OpenTrigger");
            isOpen = true;
        }
    }
   
    void OnTriggerExit(Collider other)
    {
        if (isOpen)
        {
            animator.SetTrigger("CloseTrigger");
            isOpen = false;
        }
    }
}
