#nullable enable
namespace UnityEngine.UIElements {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public static partial class VisualElementFactory {

        // Widget
        public static VisualElement Widget() {
            var result = Create<VisualElement>( "widget-view", "widget-view" );
            return AddToCurrentScope( result );
        }
        public static VisualElement LeftWidget() {
            var result = Create<VisualElement>( "left-widget-view", "left-widget-view" );
            return AddToCurrentScope( result );
        }
        public static VisualElement SmallWidget() {
            var result = Create<VisualElement>( "small-widget-view", "small-widget-view" );
            return AddToCurrentScope( result );
        }
        public static VisualElement MediumWidget() {
            var result = Create<VisualElement>( "medium-widget-view", "medium-widget-view" );
            return AddToCurrentScope( result );
        }
        public static VisualElement LargeWidget() {
            var result = Create<VisualElement>( "large-widget-view", "large-widget-view" );
            return AddToCurrentScope( result );
        }

        // Widget
        public static VisualElement DialogWidget() {
            var result = Create<VisualElement>( "dialog-widget-view", "dialog-widget-view" );
            return AddToCurrentScope( result );
        }
        public static VisualElement InfoDialogWidget() {
            var result = Create<VisualElement>( "info-dialog-widget-view", "info-dialog-widget-view" );
            return AddToCurrentScope( result );
        }
        public static VisualElement WarningDialogWidget() {
            var result = Create<VisualElement>( "warning-dialog-widget-view", "warning-dialog-widget-view" );
            return AddToCurrentScope( result );
        }
        public static VisualElement ErrorDialogWidget() {
            var result = Create<VisualElement>( "error-dialog-widget-view", "error-dialog-widget-view" );
            return AddToCurrentScope( result );
        }

        // Card
        public static Card Card() {
            var result = Create<Card>( "card" );
            return AddToCurrentScope( result );
        }
        public static Header Header() {
            var result = Create<Header>( "header" );
            return AddToCurrentScope( result );
        }
        public static Content Content() {
            var result = Create<Content>( "content" );
            return AddToCurrentScope( result );
        }
        public static Footer Footer() {
            var result = Create<Footer>( "footer" );
            return AddToCurrentScope( result );
        }

        // Card
        public static Card DialogCard() {
            var result = Create<Card>( "dialog-card", "dialog-card" );
            return AddToCurrentScope( result );
        }
        public static Card InfoDialogCard() {
            var result = Create<Card>( "info-dialog-card", "info-dialog-card" );
            return AddToCurrentScope( result );
        }
        public static Card WarningDialogCard() {
            var result = Create<Card>( "warning-dialog-card", "warning-dialog-card" );
            return AddToCurrentScope( result );
        }
        public static Card ErrorDialogCard() {
            var result = Create<Card>( "error-dialog-card", "error-dialog-card" );
            return AddToCurrentScope( result );
        }

        // Slot
        public static Slot Slot() {
            var result = Create<Slot>( "slot" );
            return AddToCurrentScope( result );
        }

        // Scope
        public static ColumnScope ColumnScope() {
            var result = Create<ColumnScope>( "scope" );
            return AddToCurrentScope( result );
        }
        public static RowScope RowScope() {
            var result = Create<RowScope>( "scope" );
            return AddToCurrentScope( result );
        }

        // Group
        public static ColumnGroup ColumnGroup() {
            var result = Create<ColumnGroup>( "group" );
            return AddToCurrentScope( result );
        }
        public static RowGroup RowGroup() {
            var result = Create<RowGroup>( "group" );
            return AddToCurrentScope( result );
        }

        // ScrollView
        public static ScrollView ScrollView() {
            var result = Create<ScrollView>( "scroll-view" );
            {
                result.horizontalScroller.highButton.BringToFront();
                result.verticalScroller.highButton.BringToFront();
            }
            return AddToCurrentScope( result );
        }

        // Box
        public static Box Box() {
            var result = Create<Box>( "box" );
            return AddToCurrentScope( result );
        }

    }
}
