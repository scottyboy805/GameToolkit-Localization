// Copyright (c) H. Ibrahim Penekli. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;
using UnityEngine.UI;

namespace GameToolkit.Localization
{
    [AddComponentMenu(ComponentMenuRoot + "Localized Image")]
    public class LocalizedImageBehaviour : LocalizedGenericAssetBehaviour<LocalizedSprite, Sprite>
    {
        [SerializeField]
        private Image image;

        protected override bool TryUpdateComponentLocalization(bool isOnValidate)
        {
            if (image != null)
            {
                image.sprite = GetLocalizedValue() as Sprite;
                return image.sprite != null;
            }
            return false;
        }
    }
}
