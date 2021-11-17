using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public Animator PlayerAnimator => GetComponent<Animator>();
    public Rigidbody PlayerRigidbody => GetComponent<Rigidbody>();

    public void StopAttackAnimation()
    {
        PlayerAnimator.SetBool("Attack", false);
    }
}
