using UnityEngine;

namespace Unity.Utils.Localization
{
    [CreateAssetMenu(fileName = "Locale Object", menuName = "Scriptable Object/Locale", order = 6)]
    public class LocaleValue : ScriptableObject
    {

        public SystemLanguage currentLocale;

        public Locale[] availableLocale;
    }
}