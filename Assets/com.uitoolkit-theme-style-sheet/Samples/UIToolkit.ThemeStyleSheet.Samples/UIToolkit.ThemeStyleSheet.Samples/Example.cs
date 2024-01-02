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
            using (var root = VisualElementFactory.Widget().Classes( "grow-1" ).Style( i => i.backgroundImage = background ).Style( i => i.unityBackgroundScaleMode = ScaleMode.StretchToFill ).AsScope()) {
                using (VisualElementFactory.LargeWidget().AsScope()) {
                    using (VisualElementFactory.Card().AsScope()) {
                        using (VisualElementFactory.Header().AsScope()) {
                            VisualElementFactory.Label( "UIToolkit Theme Style Sheet" );
                        }
                        using (VisualElementFactory.Content().AsScope()) {
                            CreateTabView();
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
        private static void CreateTabView() {
            using (VisualElementFactory.TabView().Classes( "dark", "medium", "grow-1" ).AsScope()) {
                CreateTab_ScrollView();
                CreateTab_Group();
                CreateTab_Box();
                CreateTab_Misc();
            }
        }
        private static void CreateTab_ScrollView() {
            using (VisualElementFactory.Tab( "Scroll View", false ).AsScope()) {
                using (VisualElementFactory.ScrollView().Classes( "dark", "medium", "grow-1" ).AsScope()) {
                    VisualElementFactory.Label( "Scroll View" ).Style( i => i.width = new Length( 1920, LengthUnit.Pixel ) ).Style( i => i.height = new Length( 1080, LengthUnit.Pixel ) );
                }
            }
        }
        private static void CreateTab_Group() {
            using (VisualElementFactory.Tab( "Group", false ).AsScope()) {
                using (VisualElementFactory.RowScope().AsScope()) {
                    Group( 0 ); Group( 1 ); Group( 2 ); Group( 3 ); Group( 4 ); Group( 3 ); Group( 2 ); Group( 1 ); Group( 0 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Group( 1 ); Group( 2 ); Group( 3 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 3 ); Group( 2 ); Group( 1 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Group( 2 ); Group( 3 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 3 ); Group( 2 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Group( 3 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 3 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Group( 3 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 3 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Group( 2 ); Group( 3 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 3 ); Group( 2 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Group( 1 ); Group( 2 ); Group( 3 ); Group( 4 ); Group( 4 ); Group( 4 ); Group( 3 ); Group( 2 ); Group( 1 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Group( 0 ); Group( 1 ); Group( 2 ); Group( 3 ); Group( 4 ); Group( 3 ); Group( 2 ); Group( 1 ); Group( 0 );
                }
            }
        }
        private static void CreateTab_Box() {
            using (VisualElementFactory.Tab( "Box", false ).AsScope()) {
                using (VisualElementFactory.RowScope().AsScope()) {
                    Box( 0 ); Box( 1 ); Box( 2 ); Box( 3 ); Box( 4 ); Box( 3 ); Box( 2 ); Box( 1 ); Box( 0 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Box( 1 ); Box( 2 ); Box( 3 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 3 ); Box( 2 ); Box( 1 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Box( 2 ); Box( 3 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 3 ); Box( 2 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Box( 3 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 3 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Box( 3 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 3 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Box( 2 ); Box( 3 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 3 ); Box( 2 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Box( 1 ); Box( 2 ); Box( 3 ); Box( 4 ); Box( 4 ); Box( 4 ); Box( 3 ); Box( 2 ); Box( 1 );
                }
                using (VisualElementFactory.RowScope().AsScope()) {
                    Box( 0 ); Box( 1 ); Box( 2 ); Box( 3 ); Box( 4 ); Box( 3 ); Box( 2 ); Box( 1 ); Box( 0 );
                }
            }
        }
        private static void CreateTab_Misc() {
            using (VisualElementFactory.Tab( "Misc", false ).AsScope()) {
                VisualElementFactory.Label( "Misc" );
            }
        }

        // Helpers
        private static ColumnGroup Group(int style) {
            var style_ = style switch {
                0 => "dark2",
                1 => "dark",
                2 => "gray",
                3 => "light",
                4 => "light2",
                _ => throw new Exception( "Style is invalid: " + style ),
            };
            using (var result = VisualElementFactory.ColumnGroup().Classes( style_, "width-50px", "height-50px", "justify-content-center", "align-items-center" ).AsScope()) {
                VisualElementFactory.Label( style.ToString() ).Classes( "medium" );
                return result;
            }
        }
        private static Box Box(int style) {
            var style_ = style switch {
                0 => "dark2",
                1 => "dark",
                2 => "gray",
                3 => "light",
                4 => "light2",
                _ => throw new Exception( "Style is invalid: " + style ),
            };
            using (var result = VisualElementFactory.Box().Classes( style_, "width-50px", "height-50px", "justify-content-center", "align-items-center" ).AsScope()) {
                VisualElementFactory.Label( style.ToString() ).Classes( "medium" );
                return result;
            }
        }

    }
}
