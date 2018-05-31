using UnityEngine;
using UnityEngine.SceneManagement;

public class CombatSceneNavigationManager : MonoBehaviour {

    public void NavigateToMenu()
    {
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }
}
