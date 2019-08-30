using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float restartDelay = 1.0f;

    public GameObject completedLevelUI;

    // Completing level
    public void CompleteLevel ( )
    {
        // enable our GameOver object, so it is visible
        completedLevelUI . SetActive ( true );
        // TODO play victory sound/song?
    }

    // Ending our game
    public void EndGame ( )
    {
        if ( !gameEnded )
        {
            gameEnded = true;
            Invoke ( "RestartGame", restartDelay );     // after a delay call RestartGame()
        }
    }

    // Load our first scene again = restarting the game
    public void RestartGame ( )
    {
        // TODO zmenit scenu na uvodni menu misto GetActiveScene()
        SceneManager . LoadScene ( SceneManager . GetActiveScene ( ) . name );
    }
}
