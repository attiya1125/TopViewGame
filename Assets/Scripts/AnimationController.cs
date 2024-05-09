using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected TopDownContoller contoller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        contoller = GetComponent<TopDownContoller>();
    }
}
