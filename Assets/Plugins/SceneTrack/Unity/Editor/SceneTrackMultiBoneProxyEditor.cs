﻿// Copyright 2018 E*D Films. All Rights Reserved.

/**
 * SceneTrackMultiBoneProxyEditor.cs
 *
 * A custom editor to remove all visible settings for the MutiBoneProxy component
 * 
 * @author  dotBunny <hello@dotbunny.com>
 * @version 1
 * @since   1.0.0
 */

using UnityEngine;
using UnityEditor;

namespace SceneTrack.Unity.Editor
{
    /// <summary>
    /// Custom Editor for MultiBoneProxy
    /// </summary>
    [CustomEditor(typeof(SceneTrackMultiBoneProxy))]
    public class SceneTrackMultiBroneProxyEditor : UnityEditor.Editor
    {
        private SceneTrackMultiBoneProxy _targetObject;

        public override void OnInspectorGUI()
        {
            // Get Current Reference
            _targetObject = (SceneTrackMultiBoneProxy)target;

            if ( !Application.isPlaying ) 
            {
                SceneTrack.Unity.Log.Error("Removing SceneTrackMultiBoneProxy off of " + _targetObject.gameObject.name + ". These are meant to be autogenerated.");

                // TODO: This spawns an error because the drag isn't completed
                UnityEngine.Object.DestroyImmediate(_targetObject);
            }
        }
    }
}
