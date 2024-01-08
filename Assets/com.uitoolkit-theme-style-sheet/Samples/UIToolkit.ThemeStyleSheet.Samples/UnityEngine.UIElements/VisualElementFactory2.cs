#nullable enable
namespace UnityEngine.UIElements {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public static partial class VisualElementFactory {

        // Widget
        public static Widget Widget() {
            var result = Create<Widget>( "widget" );
            return result;
        }
        public static Widget LeftWidget() {
            var result = Create<Widget>( "left-widget", "left-widget" );
            return result;
        }
        public static Widget SmallWidget() {
            var result = Create<Widget>( "small-widget", "small-widget" );
            return result;
        }
        public static Widget MediumWidget() {
            var result = Create<Widget>( "medium-widget", "medium-widget" );
            return result;
        }
        public static Widget LargeWidget() {
            var result = Create<Widget>( "large-widget", "large-widget" );
            return result;
        }

        // Widget
        public static Widget DialogWidget() {
            var result = Create<Widget>( "dialog-widget", "dialog-widget" );
            {
                result.OnAttachToPanel( evt => {
                    PlayWidgetAppearanceAnimation( result );
                } );
            }
            return result;
        }
        public static Widget InfoDialogWidget() {
            var result = Create<Widget>( "info-dialog-widget", "info-dialog-widget" );
            result.OnAttachToPanel( evt => {
                PlayWidgetAppearanceAnimation( result );
            } );
            return result;
        }
        public static Widget WarningDialogWidget() {
            var result = Create<Widget>( "warning-dialog-widget", "warning-dialog-widget" );
            result.OnAttachToPanel( evt => {
                PlayWidgetAppearanceAnimation( result );
            } );
            return result;
        }
        public static Widget ErrorDialogWidget() {
            var result = Create<Widget>( "error-dialog-widget", "error-dialog-widget" );
            result.OnAttachToPanel( evt => {
                PlayWidgetAppearanceAnimation( result );
            } );
            return result;
        }

        // Card
        public static Card Card() {
            var result = Create<Card>( "card" );
            return result;
        }
        public static Header Header() {
            var result = Create<Header>( "header" );
            return result;
        }
        public static Content Content() {
            var result = Create<Content>( "content" );
            return result;
        }
        public static Footer Footer() {
            var result = Create<Footer>( "footer" );
            return result;
        }

        // Card
        public static Card DialogCard() {
            var result = Create<Card>( "dialog-card", "dialog-card" );
            return result;
        }
        public static Card InfoDialogCard() {
            var result = Create<Card>( "info-dialog-card", "info-dialog-card" );
            return result;
        }
        public static Card WarningDialogCard() {
            var result = Create<Card>( "warning-dialog-card", "warning-dialog-card" );
            return result;
        }
        public static Card ErrorDialogCard() {
            var result = Create<Card>( "error-dialog-card", "error-dialog-card" );
            return result;
        }

        // TabView
        public static TabView TabView() {
            var result = Create<TabView>( "tab-view" );
            return result;
        }
        public static Tab Tab(string label) {
            var result = Create<Tab>( "tab" );
            {
                result.label = label;
            }
            return result;
        }

        // ScrollView
        public static ScrollView ScrollView() {
            var result = Create<ScrollView>( "scroll-view" );
            {
                result.horizontalScroller.highButton.BringToFront();
                result.verticalScroller.highButton.BringToFront();
            }
            return result;
        }

        // Slot
        public static Slot Slot() {
            var result = Create<Slot>( "slot" );
            return result;
        }

        // Scope
        public static ColumnScope ColumnScope() {
            var result = Create<ColumnScope>( "scope" );
            return result;
        }
        public static RowScope RowScope() {
            var result = Create<RowScope>( "scope" );
            return result;
        }

        // Group
        public static ColumnGroup ColumnGroup() {
            var result = Create<ColumnGroup>( "group" );
            return result;
        }
        public static RowGroup RowGroup() {
            var result = Create<RowGroup>( "group" );
            return result;
        }

        // Box
        public static Box Box() {
            var result = Create<Box>( "box" );
            return result;
        }

    }
}
