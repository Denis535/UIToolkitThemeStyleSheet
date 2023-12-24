namespace UnityEditor.UIElements {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEditor;
    using UnityEngine;

    public static class Toolbar {

        [MenuItem( "Assets/Create/UI Toolkit/Stylus" )]
        public static void CreateStylusAsset() {
            ProjectWindowUtil.CreateAssetWithContent( "New Stylus.styl", "" );
        }

        [MenuItem( "Assets/Create/UI Toolkit/Pug" )]
        public static void CreatePugAsset() {
            ProjectWindowUtil.CreateAssetWithContent( "New Pug.pug", "" );
        }

        [MenuItem( "Assets/Create/UI Toolkit/Css" )]
        public static void CreateCssAsset() {
            ProjectWindowUtil.CreateAssetWithContent( "New Css.css", "" );
        }

    }
}
