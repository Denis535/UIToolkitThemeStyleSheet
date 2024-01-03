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
            using (VisualElementFactory.Tab( "Scroll View" ).AsScope()) {
                using (VisualElementFactory.ScrollView().Classes( null, "medium", "grow-1" ).AsScope()) {
                    VisualElementFactory.VisualElement()
                        .Style( i => i.width = new Length( 1920, LengthUnit.Pixel ) )
                        .Style( i => i.height = new Length( 1080, LengthUnit.Pixel ) )
                        .Style( i => i.marginLeft = i.marginRight = i.marginTop = i.marginBottom = new Length( 0, LengthUnit.Pixel ) )
                        .AddToScope();
                }
            }
        }
        private static void CreateTab_Group() {
            using (VisualElementFactory.Tab( "Group" ).AsScope()) {
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
            static ColumnGroup Group(int style) {
                var style_ = style switch {
                    0 => "dark2",
                    1 => "dark",
                    2 => "gray",
                    3 => "light",
                    4 => "light2",
                    _ => throw new Exception( "Style is invalid: " + style ),
                };
                using (var result = VisualElementFactory.ColumnGroup().Classes( style_, "width-75px", "height-75px", "justify-content-center", "align-items-center" ).AsScope()) {
                    VisualElementFactory.Label( style.ToString() ).Classes( "medium" ).AddToScope();
                    return result;
                }
            }
        }
        private static void CreateTab_Box() {
            using (VisualElementFactory.Tab( "Box" ).AsScope()) {
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
            static Box Box(int style) {
                var style_ = style switch {
                    0 => "dark2",
                    1 => "dark",
                    2 => "gray",
                    3 => "light",
                    4 => "light2",
                    _ => throw new Exception( "Style is invalid: " + style ),
                };
                using (var result = VisualElementFactory.Box().Classes( style_, "width-75px", "height-75px", "justify-content-center", "align-items-center" ).AsScope()) {
                    VisualElementFactory.Label( style.ToString() ).Classes( "medium" ).AddToScope();
                    return result;
                }
            }
        }
        private static void CreateTab_Misc() {
            using (VisualElementFactory.Tab( "Misc" ).AsScope()) {
                VisualElementFactory.Label( "Label" ).AddToScope();
                VisualElementFactory.Button( "Button" ).AddToScope();
                VisualElementFactory.RepeatButton( "Repeat Button" ).AddToScope();
                VisualElementFactory.TextField( "Text Field", "Hello World !!!", 64, false ).AddToScope();
                VisualElementFactory.ReadOnlyTextField( "Read Only Text Field", "Hello World !!!", 64, false ).AddToScope();
                VisualElementFactory.PopupField( "Popup Field", "Item 1", new[] { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10" } ).AddToScope();
                VisualElementFactory.DropdownField( "Dropdown Field", "Item 1", new[] { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10", "Item 11", "Item 12", "Item 13", "Item 14", "Item 15", "Item 16", "Item 17", "Item 18", "Item 19", "Item 20" } ).AddToScope();
                VisualElementFactory.SliderField( "Slider Field", 5, 0, 10 ).AddToScope();
                VisualElementFactory.IntSliderField( "Int Slider Field", 5, 0, 10 ).AddToScope();
                VisualElementFactory.ToggleField( "Toggle Field", true ).AddToScope();
            }
        }

    }
}
