#if UNITY_EDITOR
#nullable enable
namespace UIToolkit.ThemeStyleSheet.Samples {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEditor;
    using UnityEngine;

    [CustomEditor( typeof( Example ), true )]
    public class ExampleEditor : Editor {

        // OnInspectorGUI
        public override void OnInspectorGUI() {
            base.OnInspectorGUI();
            EditorGUILayout.Separator();

            using (new GUILayout.VerticalScope( EditorStyles.helpBox )) {
                EditorGUILayout.LabelField( "Overview", EditorStyles.boldLabel );
                EditorGUILayout.LabelField( "The UIToolkit theme style sheet." );
                EditorGUILayout.Separator();

                EditorGUILayout.LabelField( "Links", EditorStyles.boldLabel );
                if (EditorGUILayout.LinkButton( "denis535.github.io" )) {
                    Application.OpenURL( "https://denis535.github.io" );
                }
                if (EditorGUILayout.LinkButton( "Unity Asset Store" )) {
                    Application.OpenURL( "https://assetstore.unity.com/publishers/90787" );
                }
                if (EditorGUILayout.LinkButton( "itch.io" )) {
                    Application.OpenURL( "https://denis535.itch.io/" );
                }
                if (EditorGUILayout.LinkButton( "Unity Package Registry" )) {
                    Application.OpenURL( "https://openupm.com/packages/?sort=downloads&q=denis535" );
                }
                if (EditorGUILayout.LinkButton( "YouTube" )) {
                    Application.OpenURL( "https://www.youtube.com/channel/UCLFdZl0pFkCkHpDWmodBUFg" );
                }
                if (EditorGUILayout.LinkButton( "GitHub" )) {
                    Application.OpenURL( "https://github.com/Denis535/UIToolkitThemeStyleSheet" );
                }
                EditorGUILayout.Separator();

                EditorGUILayout.LabelField( "If you want to support me", EditorStyles.boldLabel );
                EditorGUILayout.LabelField( "If you want to support me, please rate my packages, subscribe to my YouTube channel and like my videos." );
            }
        }

    }
}
#endif
