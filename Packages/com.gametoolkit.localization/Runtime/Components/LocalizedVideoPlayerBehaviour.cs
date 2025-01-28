// Copyright (c) H. Ibrahim Penekli. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;
using UnityEngine.Video;

namespace GameToolkit.Localization
{
    [AddComponentMenu(ComponentMenuRoot + "Localized Video Player")]
    public class LocalizedVideoPlayerBehaviour : LocalizedGenericAssetBehaviour<LocalizedVideoClip, VideoClip>
    {
        [SerializeField]
        private VideoPlayer videoPlayer;

        protected override bool TryUpdateComponentLocalization(bool isOnValidate)
        {
            if(videoPlayer != null)
            {
                videoPlayer.clip = GetLocalizedValue() as VideoClip;
                return videoPlayer.clip != null;
            }
            return false;
        }

        protected override void Reset()
        {
            base.Reset();
            videoPlayer = GetComponent<VideoPlayer>();
        }
    }
}