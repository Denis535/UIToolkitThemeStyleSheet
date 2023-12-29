#nullable enable
namespace UIToolkit.ThemeStyleSheet {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UIElements;

    public class Example : MonoBehaviour {

        [SerializeField] private Texture2D background = null!;

        // Awake
        public void Awake() {
            var document = GetComponent<UIDocument>();
            document.rootVisualElement.Add( CreateVisualElement() );
        }
        public void OnDestroy() {
        }

        // Start
        public void Start() {
        }
        public void Update() {
        }

        // Helpers
        private VisualElement CreateVisualElement() {
            using (var root = VisualElementFactory.Widget().Classes( "grow-1" ).Style( i => i.backgroundImage = background ).Style( i => i.unityBackgroundScaleMode = ScaleMode.StretchToFill ).AsScope()) {
                using (VisualElementFactory.LargeWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementFactory.Label( "UIToolkit Theme Style Sheet" );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            // ScrollView
                            using (VisualElementFactory.ScrollView().Classes( "dark", "medium", "grow-1" ).AsScope()) {
                                var styles = new[] { "light2", "light", "gray", "dark", "dark2" };
                                for (var y = 0; y < 30; y++) {
                                    using (VisualElementFactory.RowScope().AsScope()) {
                                        for (var x = 0; x < 30; x++) {
                                            using (VisualElementFactory.Box().Classes( styles[ x % 5 ], "width-auto", "height-auto", "flex-0", "shrink-0", "justify-content-center", "align-items-center" ).AsScope()) {
                                                VisualElementFactory.Label( styles[ x % 5 ] ).Classes( "medium" );
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        using (VisualElementFactory.Footer().AsScope()) {
                            VisualElementFactory.Button( "Submit" );
                            VisualElementFactory.Button( "Cancel" );
                        }
                    }
                }
                return root.VisualElement;
            }
        }

    }
}
