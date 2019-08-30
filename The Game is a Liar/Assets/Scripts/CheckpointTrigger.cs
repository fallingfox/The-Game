using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter ( Collider asdf )
    {
        gameManager . CompleteLevel ( );

        // Bring up DialogueWindow, write text in it, play Phone animation and Phone Idle animation

    }
}
