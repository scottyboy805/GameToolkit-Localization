// Copyright (c) H. Ibrahim Penekli. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;
using UnityEngine.UI;

namespace GameToolkit.Localization
{
    [AddComponentMenu(ComponentMenuRoot + "Localized Raw Image")]
    public class LocalizedRawImageBehaviour : LocalizedGenericAssetBehaviour<LocalizedTexture, Texture>
    {
        [SerializeField]
        private RawImage rawImage;

        protected override bool TryUpdateComponentLocalization(bool isOnValidate)
        {
            if(rawImage != null)
            {
                rawImage.texture = GetLocalizedValue() as Texture2D;
                return rawImage.texture != null;
            }
            return false;
        }
    }
}
