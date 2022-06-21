using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcontroller : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));
        anim.SetFloat("horizontal", Input.GetAxis("Horizontal"));
    }
}
