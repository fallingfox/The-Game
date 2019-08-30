using UnityEngine;
using System.Collections;

public class CheckpointTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject dialogueButton;

    public bool gamePaused = false;

    public DeerMovement deer;
    private Animator animator;

    private void OnTriggerEnter ( Collider asdf )
    {
        // Bring up DialogueWindow - po kliknuti se samotnej button vypne -> je dialogueButton.activeSelf == false
        dialogueButton . SetActive ( true );

        // Play Phone animation and Phone Idle animation
        animator = deer . GetComponent < Animator > ( );
        animator.Play ( "Phone", 0, 0 );

        // Pause the game
       Pause ( );

        // Disable box collider on this TriggerBox
        GetComponent<BoxCollider>().enabled = false;

        Resume ( );
    }

    void Pause ( )
    {
        // TODO I DONT KNOW HOW
        // musis proste nejak zastavit pohyb deera, jakkoliv, jinak se rozbije prechod animace
        // z Phone na PhoneIdle
    }

    void Resume ( )
    {
       // TODO 
    }
}
