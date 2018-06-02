using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameEndedSceneUiManager : MonoBehaviour {

    public TextMeshProUGUI informationMessage;
    public Text okButtonText;
    // Use this for initialization
    Lang locale;
    private void Start()
    {
        Lang.Instance.SetLanguage(new LangContainerPl().languageDict);
        locale = Lang.Instance;
        informationMessage.text = locale.GetTranslation(LanguageKeys.GameEndedSceneMessage);
        okButtonText.text = locale.GetTranslation(LanguageKeys.General_OK);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
