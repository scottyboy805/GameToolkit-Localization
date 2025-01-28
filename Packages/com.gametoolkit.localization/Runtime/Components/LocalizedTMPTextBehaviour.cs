using System;
using System.Linq;
using TMPro;
using UnityEngine;

namespace GameToolkit.Localization
{
    [AddComponentMenu(ComponentMenuRoot + "Localized TMP Text")]
    internal class LocalizedTMPTextBehaviour : LocalizedGenericAssetBehaviour<LocalizedText, string>
    {
        [SerializeField]
        private TMP_Text textMeshPro;
        [SerializeField]
        private string[] m_FormatArgs = new string[0];

        public string[] FormatArgs
        {
            get
            {
                return m_FormatArgs;
            }
            set
            {
                m_FormatArgs = value ?? new string[0];
                ForceUpdateComponentLocalization();
            }
        }

        protected override object GetLocalizedValue()
        {
            var value = (string)base.GetLocalizedValue();
            if (FormatArgs.Length > 0 && !string.IsNullOrEmpty(value))
            {
                return string.Format(value, FormatArgs.Cast<object>().ToArray());
            }
            return value;
        }

        protected override bool TryUpdateComponentLocalization(bool isOnValidate)
        {
            if (HasLocalizedValue() && textMeshPro != null)
            {
#if UNITY_EDITOR
                if (!Application.isPlaying)
                {
                    UnityEditor.Undo.RecordObject(textMeshPro, "Locale value change");
                }
#endif
                // Assign text
                textMeshPro.text = GetLocalizedValue() as string;
                return textMeshPro.text != null;
            }

            return false;
        }

        protected override void Reset()
        {            
            base.Reset();
            textMeshPro = GetComponent<TMP_Text>();
        }
    }
}
