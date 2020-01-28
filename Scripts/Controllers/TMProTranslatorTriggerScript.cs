using TMPro;
using UnityEngine;
using UnityTranslator;

/// <summary>
/// Unity TMPro translator triggers namespace
/// </summary>
namespace UnityTMProTranslator.Triggers
{
    /// <summary>
    /// TMPro Translator trigger script class
    /// </summary>
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TMProTranslatorTriggerScript : ATextTranslatorTriggerScript
    {
        /// <summary>
        /// Update text
        /// </summary>
        /// <param name="text">Text</param>
        protected override void UpdateString(string text)
        {
            TextMeshProUGUI text_component = GetComponent<TextMeshProUGUI>();
            if (text_component != null)
            {
                text_component.text = StringTranslation;
            }
        }
    }
}
