using UnityEngine;

public class PlayerAnimationController 
{
    private Animator _animator;

    public PlayerAnimationController(ObstacelsView[] obstacelsView, Animator animator)
    {
        _animator = animator;

        for (int i = 0; i < obstacelsView.Length; i++)
        {
            obstacelsView[i].ObstacelTouchPlayer += AnimationAttack;
        }    
    }

    private void AnimationAttack()
    {
        _animator.SetBool("Attack", true);
    }
}
