// Copyright (c) H. Ibrahim Penekli. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

namespace GameToolkit.Localization
{
    [AddComponentMenu(ComponentMenuRoot + "Localized Audio Source")]
    public class LocalizedAudioSourceBehaviour : LocalizedGenericAssetBehaviour<LocalizedAudioClip, AudioClip>
    {
        [SerializeField]
        private AudioSource audioSource;

        protected override bool TryUpdateComponentLocalization(bool isOnValidate)
        {
            if (audioSource != null)
            {
                audioSource.clip = GetLocalizedValue() as AudioClip;
                return audioSource.clip != null;
            }
            return false;
        }
    }
}
