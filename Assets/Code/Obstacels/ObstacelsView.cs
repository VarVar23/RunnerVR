using UnityEngine;
using System;

public class ObstacelsView : MonoBehaviour
{
    public Action ObstacelTouchPlayer;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            transform.parent = collision.transform;
        }
        else if (collision.collider.CompareTag("Player"))
        {
            ObstacelTouchPlayer?.Invoke();
        }
    }
}
