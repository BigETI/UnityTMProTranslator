using TMPro;
using UnityEngine;
using UnityTranslator.Triggers;

/// <summary>
/// Unity TMPro translator triggers namespace
/// </summary>
namespace UnityTMProTranslator.Triggers
{
    /// <summary>
    /// A class that describes a TextMesh Pro translator trigger script
    /// </summary>
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TMProTranslatorTriggerScript : ATextTranslatorTriggerScript, ITMProTranslatorTrigger
    {
        /// <summary>
        /// Updates string
        /// </summary>
        /// <param name="stringValue">String</param>
        protected override void UpdateString(string stringValue)
        {
            TextMeshProUGUI text_component = GetComponent<TextMeshProUGUI>();
            if (text_component != null)
            {
                text_component.text = StringTranslation;
            }
        }
    }
}
