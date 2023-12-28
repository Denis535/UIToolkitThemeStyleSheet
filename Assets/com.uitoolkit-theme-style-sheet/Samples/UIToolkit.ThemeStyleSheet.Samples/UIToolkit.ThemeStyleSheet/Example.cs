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
            using (var root = VisualElementFactory.Widget().Classes( "grow-1" ).Style( i => i.backgroundImage = new StyleBackground( background ) ).AsScope()) {
                using (VisualElementFactory.LargeWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementFactory.Label( "UIToolkit Theme Style Sheet" );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            using (VisualElementFactory.ScrollView().Classes( "dark", "grow-1" ).AsScope()) {
                                for (var i = 0; i < 50; i++) {
                                    var style = new[] { "light2", "light", "gray", "dark", "dark2" }[ i % 5 ];
                                    using (VisualElementFactory.Box().Classes( style, "justify-content-center", "align-items-left", "width-200pc", "height-100px" ).AsScope()) {
                                        VisualElementFactory.Label( style ).Classes( "medium" );
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
