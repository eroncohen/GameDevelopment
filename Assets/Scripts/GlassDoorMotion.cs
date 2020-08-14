using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassDoorMotion : MonoBehaviour
{
    public bool isOpen;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="MainCamera")
        {
            isOpen = true;
            animator.SetTrigger("Open");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (isOpen)
        {
            isOpen = false;
            animator.SetTrigger("Close");
        }
    }
}
