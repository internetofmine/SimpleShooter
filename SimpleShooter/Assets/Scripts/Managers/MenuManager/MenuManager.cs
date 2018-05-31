using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager: MonoBehaviour
{

    public void NavigateToGame()
    {
        SceneManager.LoadScene("CombatScene", LoadSceneMode.Single);
    }

    public void NavigateToExit()
    {
        Application.Quit();
    }


}
