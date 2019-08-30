using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float restartDelay = 1.0f;

    public GameObject completedLevelUI;
    public GameObject failedLevelUI;

    // Good ending
    public void CompleteLevel ( )
    {
        // enable our GameOver object, so it is visible
        completedLevelUI . SetActive ( true );

        // TODO play victory sound/song?
    }

    // Bad ending
    public void EndGame ( )
    {
        // enable our GameOver object, so it is visible
        failedLevelUI. SetActive ( true );

        // TODO play Another One Bites the Dust

        // TODO quit the game button?
    }

    /**  Asi ani neni nikde potreba restartovat to
    
    // Load our first scene again = restarting the game
    public void RestartGame ( )
    {
        // TODO zmenit scenu na uvodni menu misto GetActiveScene()
        SceneManager . LoadScene ( SceneManager . GetActiveScene ( ) . name );
    }

    **/
}
