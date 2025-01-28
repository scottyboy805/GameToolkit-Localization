// Copyright (c) H. Ibrahim Penekli. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using TMPro;
using UnityEngine;

namespace GameToolkit.Localization
{
    [CreateAssetMenu(fileName = "LocalizedFont", menuName = "GameToolkit Localization/TMP Font")]
    public class LocalizedFont : LocalizedAsset<TMP_FontAsset>
    {
        [Serializable]
        private class FontLocaleItem : LocaleItem<TMP_FontAsset> { };

        [SerializeField]
        private FontLocaleItem[] m_LocaleItems = new FontLocaleItem[1];

        public override LocaleItemBase[] LocaleItems { get { return m_LocaleItems; } }
    }
}