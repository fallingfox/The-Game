using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLvl ( )
    {
        // Loadni scénu, která ma build index 0 (najdeš to když dáš Build) - ideálně hlavní menu
        SceneManager . LoadScene ( 0 );
    }

}
