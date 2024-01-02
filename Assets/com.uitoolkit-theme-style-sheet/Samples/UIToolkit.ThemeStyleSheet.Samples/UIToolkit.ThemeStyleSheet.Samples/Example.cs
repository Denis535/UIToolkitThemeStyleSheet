#nullable enable
namespace UIToolkit.ThemeStyleSheet.Samples {
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
            //using (var root = VisualElementFactory.TabView().Style( i => i.flexGrow = 1 ).AsScope()) {
            //    using (VisualElementFactory.Tab( "Tab 1", false ).AsScope()) {
            //        using (VisualElementFactory.Box().Style( i => i.height = new Length( 600, LengthUnit.Pixel ) ).AsScope()) {
            //            VisualElementFactory.Label( "box 1" );
            //        }
            //    }
            //    using (VisualElementFactory.Tab( "Tab 2", false ).AsScope()) {
            //        using (VisualElementFactory.Box().Style( i => i.height = new Length( 600, LengthUnit.Pixel ) ).AsScope()) {
            //            VisualElementFactory.Label( "box 2" );
            //        }
            //    }
            //    using (VisualElementFactory.Tab( "Tab 3", false ).AsScope()) {
            //        using (VisualElementFactory.Box().Style( i => i.height = new Length( 600, LengthUnit.Pixel ) ).AsScope()) {
            //            VisualElementFactory.Label( "box 3" );
            //        }
            //    }
            //    return root.VisualElement;
            //}

            using (var root = VisualElementFactory.Widget().Classes( "grow-1" ).Style( i => i.backgroundImage = background ).Style( i => i.unityBackgroundScaleMode = ScaleMode.StretchToFill ).AsScope()) {
                using (VisualElementFactory.LargeWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementFactory.Label( "UIToolkit Theme Style Sheet" );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            using (VisualElementFactory.TabView().Classes( "dark", "medium", "grow-1" ).AsScope()) {
                                using (VisualElementFactory.Tab( "Tab 1", false ).AsScope()) {
                                    using (VisualElementFactory.Box().Classes( "gray", "margin-0pc", "grow-1", "justify-content-center", "align-items-center" ).AsScope()) {
                                        VisualElementFactory.Label( "Box 1" ).Classes( "medium" );
                                    }
                                }
                                using (VisualElementFactory.Tab( "Tab 2", false ).AsScope()) {
                                    using (VisualElementFactory.Box().Classes( "gray", "margin-0pc", "grow-1", "justify-content-center", "align-items-center" ).AsScope()) {
                                        VisualElementFactory.Label( "Box 2" ).Classes( "medium" );
                                    }
                                }
                                using (VisualElementFactory.Tab( "Tab 3", false ).AsScope()) {
                                    using (VisualElementFactory.Box().Classes( "gray", "margin-0pc", "grow-1", "justify-content-center", "align-items-center" ).AsScope()) {
                                        VisualElementFactory.Label( "Box 3" ).Classes( "medium" );
                                    }
                                }
                            }

                            //using (VisualElementFactory.ScrollView().Classes( "dark", "medium", "grow-1" ).AsScope()) {
                            //    for (var y = 0; y < 8; y++) {
                            //        using (VisualElementFactory.RowScope().AsScope()) {
                            //            for (var x = 0; x < 8; x++) {
                            //                var styles = new[] { "light2", "light", "gray", "dark", "dark2" };
                            //                using (VisualElementFactory.ColumnGroup().AsScope()) {
                            //                    for (var y2 = 0; y2 < 5; y2++) {
                            //                        using (VisualElementFactory.RowScope().AsScope()) {
                            //                            for (var x2 = 0; x2 < 5; x2++) {
                            //                                var style = styles[ Mathf.Max( x2, y2 ) ];
                            //                                using (VisualElementFactory.Box().Classes( style, "width-100px", "height-100px", "justify-content-center", "align-items-center" ).AsScope()) {
                            //                                    VisualElementFactory.Label( style ).Classes( "medium" );
                            //                                }
                            //                            }
                            //                        }
                            //                    }
                            //                }
                            //            }
                            //        }
                            //    }
                            //}
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
