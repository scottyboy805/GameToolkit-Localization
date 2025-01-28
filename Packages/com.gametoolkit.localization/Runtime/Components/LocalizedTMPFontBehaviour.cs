// Copyright (c) H. Ibrahim Penekli. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameToolkit.Localization
{
    [AddComponentMenu(ComponentMenuRoot + "Localized TMP Font")]
    public class LocalizedFontBehaviour : LocalizedGenericAssetBehaviour<LocalizedFont, TMP_FontAsset>
    {
        [SerializeField]
        private TMP_Text textMeshPro;

        protected override bool TryUpdateComponentLocalization(bool isOnValidate)
        {
            if(textMeshPro != null)
            {
                textMeshPro.font = GetLocalizedValue() as TMP_FontAsset;
                return textMeshPro.font != null;
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
