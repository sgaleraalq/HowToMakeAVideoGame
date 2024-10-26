using UnityEngine;

public class PlayerCollission : MonoBehaviour
{

    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            movement.enabled = false;
        }
    }
}
