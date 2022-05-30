using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animation Anim;

    private void Awake()
    {
        Anim = GetComponent<Animation>();
    }
    public void Idle()
    {
        Anim.Play("idle");
    }

    public void Run()
    {
        Anim.Play("run");
    }
}
