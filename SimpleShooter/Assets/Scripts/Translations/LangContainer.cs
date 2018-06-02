using System.Collections.Generic;

namespace Assets.Scripts.Translations
{
    public class LangContainer
    {
        public Dictionary<string, string> languageDict = new Dictionary<string, string>()
        {
            {"CombatScene_QuitTitle", "Confirm Exit"},
            {"CombatScene_QuitMessage", "You Will Exit To Menu"},
            {"CombatScene_QuitConfirm", "OK"},
            {"CombatScene_QuitCancel", "Cancel" }
        };
    }
}
