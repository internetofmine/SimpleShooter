using Assets.Scripts.Translations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LangContainerPl : LangContainer
{
    public new Dictionary<string, string> languageDict = new Dictionary<string, string>()
        {
            {"CombatScene_QuitTitle", "Potwierdź wyjście"},
            {"CombatScene_QuitMessage", "Aplikacja się wyłączy"},
            {"CombatScene_QuitConfirm", "OK"},
            {"CombatScene_QuitCancel", "Anuluj" }
        };
}
