#if UNITY_EDITOR
#nullable enable
namespace UIToolkit.ThemeStyleSheet.Samples {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading;
    using UnityEditor;
    using UnityEditorInternal;
    using UnityEngine;

    public static class Toolbar {

        // CreateAsset
        [MenuItem( "Assets/Create/UI Toolkit/Pug" )]
        public static void CreateAsset_Pug() {
            ProjectWindowUtil.CreateAssetWithContent( "New Pug.pug", "" );
        }
        [MenuItem( "Assets/Create/UI Toolkit/Css" )]
        public static void CreateAsset_Css() {
            ProjectWindowUtil.CreateAssetWithContent( "New Css.css", "" );
        }
        [MenuItem( "Assets/Create/UI Toolkit/Sass" )]
        public static void CreateAsset_Sass() {
            ProjectWindowUtil.CreateAssetWithContent( "New Sass.sass", "" );
        }
        [MenuItem( "Assets/Create/UI Toolkit/Stylus" )]
        public static void CreateAsset_Stylus() {
            ProjectWindowUtil.CreateAssetWithContent( "New Stylus.styl", "" );
        }

        // OpenAssets
        [MenuItem( "Tools/UIToolkitThemeStyleSheet/Open All (UXML)", secondaryPriority = 0 )]
        public static void OpenAssets_UXML() {
            OpenAssets( "Assets/(*.uxml)" );
            OpenAssets( "Packages/(*.uxml)" );
        }
        [MenuItem( "Tools/UIToolkitThemeStyleSheet/Open All (Pug)", secondaryPriority = 1 )]
        public static void OpenAssets_Pug() {
            OpenAssets( "Assets/(*.pug)" );
            OpenAssets( "Packages/(*.pug)" );
        }
        [MenuItem( "Tools/UIToolkitThemeStyleSheet/Open All (USS)", secondaryPriority = 2 )]
        public static void OpenAssets_USS() {
            OpenAssets( "Assets/(*.uss)" );
            OpenAssets( "Packages/(*.uss)" );
        }
        [MenuItem( "Tools/UIToolkitThemeStyleSheet/Open All (CSS)", secondaryPriority = 3 )]
        public static void OpenAssets_CSS() {
            OpenAssets( "Assets/(*.css)" );
            OpenAssets( "Packages/(*.css)" );
        }
        [MenuItem( "Tools/UIToolkitThemeStyleSheet/Open All (Sass)", secondaryPriority = 4 )]
        public static void OpenAssets_Sass() {
            OpenAssets( "Assets/(*.sass)" );
            OpenAssets( "Packages/(*.sass)" );
        }
        [MenuItem( "Tools/UIToolkitThemeStyleSheet/Open All (Stylus)", secondaryPriority = 4 )]
        public static void OpenAssets_Stylus() {
            OpenAssets( "Assets/(*.stylus|*.styl)" );
            OpenAssets( "Packages/(*.stylus|*.styl)" );
        }

        // TakeScreenshot
        [MenuItem( "Tools/UIToolkitThemeStyleSheet/Take Screenshot (Game) _F12", secondaryPriority = 100 )]
        internal static void TakeScreenshot_Game() {
            var path = $"Screenshots/{Application.productName}-{DateTime.UtcNow.Ticks}.png";
            ScreenCapture.CaptureScreenshot( path, 1 );
            EditorApplication.Beep();
            EditorUtility.RevealInFinder( path );
        }
        [MenuItem( "Tools/UIToolkitThemeStyleSheet/Take Screenshot (Editor) &F12", secondaryPriority = 101 )]
        internal static void TakeScreenshot_Editor() {
            var position = EditorGUIUtility.GetMainWindowPosition();
            var texture = new Texture2D( (int) position.width, (int) position.height );
            texture.SetPixels( InternalEditorUtility.ReadScreenPixel( position.position, (int) position.width, (int) position.height ) );
            var bytes = texture.EncodeToPNG();
            UnityEngine.Object.DestroyImmediate( texture );

            var path = $"Screenshots/{Application.productName}-{DateTime.UtcNow.Ticks}.png";
            Directory.CreateDirectory( Path.GetDirectoryName( path ) );
            File.WriteAllBytes( path, bytes );
            EditorApplication.Beep();
            EditorUtility.RevealInFinder( path );
        }

        // Helpers
        private static void OpenAssets(params string[] patterns) {
            foreach (var path in GetMatches( GetPaths(), patterns )) {
                if (!Path.GetFileName( path ).StartsWith( "_" )) {
                    AssetDatabase.OpenAsset( AssetDatabase.LoadAssetAtPath<UnityEngine.Object>( path ) );
                    Thread.Sleep( 500 );
                }
            }
        }
        private static void OpenAssetsReverse(params string[] patterns) {
            foreach (var path in GetMatches( GetPaths(), patterns ).Reverse()) {
                if (!Path.GetFileName( path ).StartsWith( "_" )) {
                    AssetDatabase.OpenAsset( AssetDatabase.LoadAssetAtPath<UnityEngine.Object>( path ) );
                    Thread.Sleep( 500 );
                }
            }
        }
        // Helpers
        private static IEnumerable<string> GetPaths() {
            var path = Directory.GetCurrentDirectory();
            return GetPaths( path )
                .Select( i => Path.GetRelativePath( path, i ) )
                .Select( i => i.Replace( '\\', '/' ) );
        }
        private static IEnumerable<string> GetPaths(string path) {
            foreach (var file in Directory.EnumerateFiles( path ).OrderBy( i => i )) {
                yield return file;
            }
            foreach (var dir in Directory.EnumerateDirectories( path ).OrderBy( i => i )) {
                yield return dir;
                foreach (var i in GetPaths( dir )) yield return i;
            }
        }
        // Helpers
        private static IEnumerable<string> GetMatches(IEnumerable<string> paths, string[] patterns) {
            paths = paths.ToList();
            foreach (var pattern in patterns) {
                var regex = new Regex( "^" + pattern.Replace( " ", "" ).Replace( "*", "(.*?)" ) + "$", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace );
                foreach (var path in paths.Where( path => regex.IsMatch( path ) )) {
                    yield return path;
                }
            }
        }

    }
}
#endif
