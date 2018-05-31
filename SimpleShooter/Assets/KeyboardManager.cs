using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
    public CombatSceneNavigationManager combatSceneNavigationManager;

    Lang languageUsed = new Lang();
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            QuitDialog();
        }
	}

    public void QuitDialog()
    {
        if (EditorUtility.DisplayDialog(languageUsed.CombatScene_QuitTitle, languageUsed.CombatScene_QuitConfirm, languageUsed.CombatScene_QuitConfirm, languageUsed.CombatScene_QuitCancel))
        {
            combatSceneNavigationManager.NavigateToMenu();
        };
    }
}
