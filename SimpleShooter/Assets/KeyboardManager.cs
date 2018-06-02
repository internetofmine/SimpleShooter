using Assets.Scripts.Translations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
    public CombatSceneNavigationManager combatSceneNavigationManager;

    Lang locale;
    private void Start()
    {
        Lang.Instance.SetLanguage(new LangContainerPl().languageDict);
        locale = Lang.Instance;
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            QuitDialog();
        }
	}

    public void QuitDialog()
    {
        if (EditorUtility.DisplayDialog(locale.GetTranslation(LanguageKeys.CombatScene_QuitTitle),
                                        locale.GetTranslation(LanguageKeys.CombatScene_QuitMessage),
                                        locale.GetTranslation(LanguageKeys.CombatScene_QuitConfirm),
                                        locale.GetTranslation(LanguageKeys.CombatScene_QuitCancel)))
        {
            combatSceneNavigationManager.NavigateToMenu();
        };
    }
}
