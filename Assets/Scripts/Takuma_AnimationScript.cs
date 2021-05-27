using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takuma_AnimationScript : MonoBehaviour
{
    public AnimationClip currentClip;
    public Animator animator;

    private void Awake() => animator = GetComponent<Animator>();

    public void GoToFrame(float desiredFrame)
    {
        var currentClip = animator.GetCurrentAnimatorClipInfo(0)[0].clip;
        var animationName = currentClip.name;
        var nbFramesInClip = currentClip.length * 60f;
        animator.Play(animationName, 0, ( 1f / nbFramesInClip ) * desiredFrame);
    }
}