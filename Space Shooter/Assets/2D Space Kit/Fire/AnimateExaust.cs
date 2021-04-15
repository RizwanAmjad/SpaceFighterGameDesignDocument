using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateExaust : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal_input = Input.GetAxis("Horizontal");
        animator.SetBool("isMoving", horizontal_input != 0.0);
    }
}
