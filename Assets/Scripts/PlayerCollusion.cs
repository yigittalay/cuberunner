using UnityEngine;

public class PlayerCollusion : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Obstacle"))
        {
            movement.enabled = false;
            GameManager.Instance.EndGame();

        }
    }
}
