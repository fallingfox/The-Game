using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider asdf)
    {
        EndGame ( );
    }

    void EndGame ( )
    {
        gameManager . EndGame ( );
    }
}
