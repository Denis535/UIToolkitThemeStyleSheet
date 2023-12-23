#if UNITY_EDITOR
namespace UnityEditor.UIElements {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using UnityEditor.AssetImporters;
    using UnityEngine;

    [ScriptedImporter( 1, "pug" )]
    public class PugImporter : ScriptedImporter {

        [MenuItem( "Assets/Create/UI Toolkit/Pug" )]
        public static void CreateAsset() {
            ProjectWindowUtil.CreateAssetWithContent( "New Document.pug", "" );
        }

        public override void OnImportAsset(AssetImportContext context) {
        }

    }
    public class PugPostprocessor : AssetPostprocessor {

        // OnPostprocessAllAssets
        public static void OnPostprocessAllAssets(string[] imported, string[] deleted, string[] moved, string[] movedFrom) {
            foreach (var imported_ in imported) {
                OnAssetImported( imported_ );
            }
            foreach (var deleted_ in deleted) {
                OnAssetDeleted( deleted_ );
            }
            foreach (var (moved_, movedFrom_) in moved.Zip( movedFrom, (a, b) => (a, b) )) {
                OnAssetMoved( moved_, movedFrom_ );
            }
        }

        // OnAssetImported
        private static void OnAssetImported(string path) {
            if (IsPug( path ) && IsSupported( path )) {
                CompilePug( path, Path.ChangeExtension( path, ".uxml" ) );
                AssetDatabase.ImportAsset( Path.ChangeExtension( path, ".uxml" ) );
            }
        }

        // OnAssetDeleted
        private static void OnAssetDeleted(string path) {
            if (IsPug( path )) {
                AssetDatabase.DeleteAsset( Path.ChangeExtension( path, ".uxml" ) );
            }
        }

        // OnAssetMoved
        private static void OnAssetMoved(string newPath, string oldPath) {
            if (IsPug( oldPath )) {
                AssetDatabase.MoveAsset( Path.ChangeExtension( oldPath, ".uxml" ), Path.ChangeExtension( newPath, ".uxml" ) );
            }
        }

        // CompilePug
        private static void CompilePug(string src, string dist) {
            NodeJS.EvaluateJavaScript( $@"
            const FS = require('fs');
            const Path = require('path');
            const Pug = require( require.resolve('pug', {{ paths: [ Path.join(process.env.APPDATA, '/npm/node_modules') ] }} ) );

            const src = '{src}';
            const dist = '{dist}';
            const source = FS.readFileSync(src, 'utf8');
            const options = {{
                doctype: 'xml',
                pretty: true
            }};

            Pug.render(source, options, onComplete);

            // onCallback
            function onComplete(error, result) {{
                if (error) {{
                    console.error(error);
                    FS.writeFile(dist, '', onError);
                }} else {{
                    FS.writeFile(dist, result.replaceAll('::', '.'), onError);
                }}
            }}
            function onError(error) {{
                if (error) {{
                    console.error(error);
                }}
            }}
            " );
        }

        // Helpers
        private static bool IsPug(string path) {
            return Path.GetExtension( path ) == ".pug";
        }
        private static bool IsSupported(string path) {
            return !Path.GetFileName( path ).StartsWith( "_" );
        }

    }
}
#endif
