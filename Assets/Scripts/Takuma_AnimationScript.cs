using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Takuma_AnimationScript : MonoBehaviour
{
    private AnimationClip currentClip;
    private Animator animator;

    private void Awake() => animator = GetComponent<Animator>();

    private void Update() {
        if (Input.GetKey(KeyCode.DownArrow) && !Input.GetKeyUp(KeyCode.DownArrow))
            animator.Play("Takuma_CROUCH", 0);
        else if (!Input.GetKey(KeyCode.DownArrow) && Input.GetKeyUp(KeyCode.DownArrow))
            animator.Play("Takuma_IDLE", 0);
    }

    private void GoToFrame(float desiredFrame)
    {
        var currentClip = animator.GetCurrentAnimatorClipInfo(0)[0].clip;
        Debug.Log(currentClip.name);
        var nbFramesInClip = currentClip.length * 60f;
        animator.Play(currentClip.name, 0, ( 1f / nbFramesInClip ) * desiredFrame);
    }
}