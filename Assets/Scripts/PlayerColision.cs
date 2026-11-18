using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    [SerializerField] private MovementPlayer playerMovementScript;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            Debug.Log("On a touché" + collisionInfo.collider.name);
            playerMovementScript.enabled = false;

        }
    }
}

