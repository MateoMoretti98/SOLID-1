using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class LocalizationManager
{
    private Dictionary<string, Dictionary<string, string>> _texts;

    public LocalizationManager()
    {
        var reader = new JsonReader("localization");
        _texts = new Dictionary<string, Dictionary<string, string>>
        {
            { LocalizaitonLanguages.ENGLISH, new Dictionary<string, string>() },
            { LocalizaitonLanguages.SPANISH, new Dictionary<string, string>() },
            { LocalizaitonLanguages.PORTUGESE, new Dictionary<string, string>() }
        };

        foreach (var item in reader.LoadFromDisk())
        {
            _texts[item.language].Add(item.textKey, item.textValue);
        }
    }

    public string GetText(string language, string key)
    {
        if (_texts[language].ContainsKey(key)) return _texts[language][key];
        return null;
    }
}
