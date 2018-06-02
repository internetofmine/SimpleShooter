using Assets.Scripts.Translations;
using System.Collections.Generic;

public sealed class Lang
{
    private static readonly Lang instance = new Lang();

    static Lang() {
        langContainer = new Dictionary<string, string>();
    }

    private Lang() {
        langContainer = new Dictionary<string, string>();
    }
    
    private static Dictionary<string, string> langContainer;

    public static Lang Instance
    {
        get
        {
            return instance;
        }
    }

    public void SetLanguage(Dictionary<string, string> langContainer)
    {
        Lang.langContainer = langContainer;
    }

    public string GetTranslation(LanguageKeys langKey)
    {
        return Lang.langContainer[langKey.ToString()];
    }
}

