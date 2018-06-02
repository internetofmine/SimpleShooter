using System.Collections.Generic;

namespace Assets.Scripts.Translations
{
    public class LangContainer
    {
        public Dictionary<string, string> languageDict = new Dictionary<string, string>()
        {
            {"General_OK", "OK"},

            {"CombatScene_QuitTitle", "Confirm Exit"},
            {"CombatScene_QuitMessage", "You Will Exit To Menu"},
            {"CombatScene_QuitConfirm", "OK"},
            {"CombatScene_QuitCancel", "Cancel" },

            {"GameEndedSceneMessage", "Game Over, press OK to return to the menu" }
        };
    }
}
