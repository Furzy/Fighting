using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takuma_AnimationScript : MonoBehaviour
{
    public AnimationClip currentClip;
    public float total_frames_in_animation;
    public float desired_frame;
    public Animator animator;

    private void Awake() => animator = GetComponent<Animator>();

    public void DoLoop(string animationName)
    {
        currentClip = animator.GetCurrentAnimatorClipInfo(0)[0].clip;
        total_frames_in_animation = currentClip.length;
        Debug.log(total_frames_in_animation.ToString());
        desired_frame = 43f;
        animator.Play(animationName, 0, ( 1f / total_frames_in_animation ) * desired_frame);

    }
}