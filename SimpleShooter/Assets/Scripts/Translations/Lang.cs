using System.Collections.Generic;

public sealed class Lang
{
    private static readonly Lang instance = new Lang();

    static Lang() { }
    private Lang() { }
    
    private Dictionary<string, string> langContainer;

    public static Lang Instance
    {
        get
        {
            return instance;
        }
    }

    public void SetLanguage(Dictionary<string, string> langContainer)
    {
        this.langContainer = langContainer;
    }

    public string GetTranslation(LanguageKeys langKey)
    {
        return this.langContainer[langKey.ToString()];
    }
}

