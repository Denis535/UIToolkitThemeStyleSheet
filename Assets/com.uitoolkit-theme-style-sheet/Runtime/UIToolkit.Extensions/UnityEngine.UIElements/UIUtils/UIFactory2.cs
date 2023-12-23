#nullable enable
namespace UnityEngine.UIElements {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public static partial class UIFactory {

        // Widget
        public static VisualElement Widget(string name = "widget-view") {
            var result = Create<VisualElement>( name, "widget-view" );
            VisualElementScope.Current?.Add( result );
            return result;
        }
        public static VisualElement LeftWidget(string name = "left-widget-view") {
            var result = Create<VisualElement>( name, "left-widget-view" );
            VisualElementScope.Current?.Add( result );
            return result;
        }
        public static VisualElement SmallWidget(string name = "small-widget-view") {
            var result = Create<VisualElement>( name, "small-widget-view" );
            VisualElementScope.Current?.Add( result );
            return result;
        }
        public static VisualElement MediumWidget(string name = "medium-widget-view") {
            var result = Create<VisualElement>( name, "medium-widget-view" );
            VisualElementScope.Current?.Add( result );
            return result;
        }
        public static VisualElement LargeWidget(string name = "large-widget-view") {
            var result = Create<VisualElement>( name, "large-widget-view" );
            VisualElementScope.Current?.Add( result );
            return result;
        }

        // Widget
        public static VisualElement DialogWidget(string name = "dialog-widget-view") {
            var result = Create<VisualElement>( name, "dialog-widget-view" );
            VisualElementScope.Current?.Add( result );
            return result;
        }
        public static VisualElement InfoDialogWidget(string name = "info-dialog-widget-view") {
            var result = Create<VisualElement>( name, "info-dialog-widget-view" );
            VisualElementScope.Current?.Add( result );
            return result;
        }
        public static VisualElement WarningDialogWidget(string name = "warning-dialog-widget-view") {
            var result = Create<VisualElement>( name, "warning-dialog-widget-view" );
            VisualElementScope.Current?.Add( result );
            return result;
        }
        public static VisualElement ErrorDialogWidget(string name = "error-dialog-widget-view") {
            var result = Create<VisualElement>( name, "error-dialog-widget-view" );
            VisualElementScope.Current?.Add( result );
            return result;
        }

        // Card
        public static Card Card() {
            var result = Create<Card>( "card" );
            VisualElementScope.Current?.Add( result );
            return result;
        }
        public static Header Header() {
            var result = Create<Header>( "header" );
            VisualElementScope.Current?.Add( result );
            return result;
        }
        public static Content Content() {
            var result = Create<Content>( "content" );
            VisualElementScope.Current?.Add( result );
            return result;
        }
        public static Footer Footer() {
            var result = Create<Footer>( "footer" );
            VisualElementScope.Current?.Add( result );
            return result;
        }

        // Card
        public static Card DialogCard() {
            var result = Create<Card>( "dialog-card", "dialog-card" );
            VisualElementScope.Current?.Add( result );
            return result;
        }
        public static Card InfoDialogCard() {
            var result = Create<Card>( "info-dialog-card", "info-dialog-card" );
            VisualElementScope.Current?.Add( result );
            return result;
        }
        public static Card WarningDialogCard() {
            var result = Create<Card>( "warning-dialog-card", "warning-dialog-card" );
            VisualElementScope.Current?.Add( result );
            return result;
        }
        public static Card ErrorDialogCard() {
            var result = Create<Card>( "error-dialog-card", "error-dialog-card" );
            VisualElementScope.Current?.Add( result );
            return result;
        }

        // Slot
        public static Slot Slot() {
            var result = Create<Slot>( "slot" );
            VisualElementScope.Current?.Add( result );
            return result;
        }

        // Scope
        public static ColumnScope ColumnScope() {
            var result = Create<ColumnScope>( "scope" );
            VisualElementScope.Current?.Add( result );
            return result;
        }
        public static RowScope RowScope() {
            var result = Create<RowScope>( "scope" );
            VisualElementScope.Current?.Add( result );
            return result;
        }

        // Group
        public static ColumnGroup ColumnGroup() {
            var result = Create<ColumnGroup>( "group" );
            VisualElementScope.Current?.Add( result );
            return result;
        }
        public static RowGroup RowGroup() {
            var result = Create<RowGroup>( "group" );
            VisualElementScope.Current?.Add( result );
            return result;
        }

        // ScrollView
        public static ScrollView ScrollView() {
            var result = Create<ScrollView>( "scroll-view" );
            {
                result.horizontalScroller.highButton.BringToFront();
                result.verticalScroller.highButton.BringToFront();
            }
            VisualElementScope.Current?.Add( result );
            return result;
        }

        // Box
        public static Box Box() {
            var result = Create<Box>( "box" );
            VisualElementScope.Current?.Add( result );
            return result;
        }

    }
}
