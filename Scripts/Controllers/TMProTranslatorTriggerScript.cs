using TMPro;
using UnityEngine;
using UnityTranslator.Objects;

/// <summary>
/// Unity TMPro translator triggers namespace
/// </summary>
namespace UnityTMProTranslator.Triggers
{
    /// <summary>
    /// TMPro Translator trigger script class
    /// </summary>
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TMProTranslatorTriggerScript : MonoBehaviour
    {
        /// <summary>
        /// Translation object
        /// </summary>
        [SerializeField]
        private TranslationObjectScript translationObject = default;

        /// <summary>
        /// Translation
        /// </summary>
        public string Translation
        {
            get
            {
                return ((translationObject == null) ? string.Empty : translationObject.ToString());
            }
        }

        /// <summary>
        /// Start
        /// </summary>
        private void Start()
        {
            TextMeshProUGUI text = GetComponent<TextMeshProUGUI>();
            if (text != null)
            {
                text.text = Translation;
            }
            Destroy(this);
        }
    }
}
