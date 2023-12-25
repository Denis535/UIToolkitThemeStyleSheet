#nullable enable
namespace UnityEditor.UIElements {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading;
    using UnityEditor;
    using UnityEngine;

    public static class Toolbar {

        // CreateAsset
        [MenuItem( "Assets/Create/UI Toolkit/Pug" )]
        public static void CreatePugAsset() {
            ProjectWindowUtil.CreateAssetWithContent( "New Pug.pug", "" );
        }
        [MenuItem( "Assets/Create/UI Toolkit/Css" )]
        public static void CreateCssAsset() {
            ProjectWindowUtil.CreateAssetWithContent( "New Css.css", "" );
        }
        [MenuItem( "Assets/Create/UI Toolkit/Stylus" )]
        public static void CreateStylusAsset() {
            ProjectWindowUtil.CreateAssetWithContent( "New Stylus.styl", "" );
        }

        // OpenAssets
        [MenuItem( "Assets/Open All/UI Toolkit/UXML", secondaryPriority = 0 )]
        public static void OpenAssets_UXML() {
            OpenAssets( "Assets/(*.uxml)" );
            OpenAssets( "Packages/(*.uxml)" );
        }
        [MenuItem( "Assets/Open All/UI Toolkit/Pug", secondaryPriority = 1 )]
        public static void OpenAssets_Pug() {
            OpenAssets( "Assets/(*.pug)" );
            OpenAssets( "Packages/(*.pug)" );
        }
        [MenuItem( "Assets/Open All/UI Toolkit/USS", secondaryPriority = 2 )]
        public static void OpenAssets_USS() {
            OpenAssets( "Assets/(*.uss)" );
            OpenAssets( "Packages/(*.uss)" );
        }
        [MenuItem( "Assets/Open All/UI Toolkit/CSS", secondaryPriority = 3 )]
        public static void OpenAssets_CSS() {
            OpenAssets( "Assets/(*.css)" );
            OpenAssets( "Packages/(*.css)" );
        }
        [MenuItem( "Assets/Open All/UI Toolkit/Stylus", secondaryPriority = 4 )]
        public static void OpenAssets_Stylus() {
            OpenAssets( "Assets/(*.stylus|*.styl)" );
            OpenAssets( "Packages/(*.stylus|*.styl)" );
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
