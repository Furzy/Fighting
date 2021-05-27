using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takuma_IDLE_Loop : MonoBehaviour
{
    public float total_frames_in_animation = 120f;
    public float desired_frame = 43f;
    public Animator animator;

    private void Awake() {
        animator = GetComponent<Animator>();
    }

    public void IdleLoop()
    {
        animator.Play ("Takuma_IDLE", 0, ( 1f / total_frames_in_animation ) * desired_frame);
    }
}
