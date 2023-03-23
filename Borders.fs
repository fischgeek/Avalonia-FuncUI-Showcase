namespace AvaloniaFuncUIShowcase

open Avalonia.Controls
open Avalonia.FuncUI.DSL
open Avalonia.Layout
open Avalonia.Controls
open Avalonia.Media
open Avalonia
open Avalonia.Controls
open Avalonia.Media
open Avalonia.Controls
open Avalonia.Controls.Shapes
open Avalonia
open Avalonia.Media
open Avalonia.FuncUI.DSL.Border
open Avalonia.FuncUI.DSL.Border
open Avalonia.FuncUI.DSL.Border
open Avalonia.Media
open Avalonia.Controls

module Borders =
    let private codeBlock = 
        let c = 
            TextBlock.create [ 
                TextBlock.text """{"Key":"Value"}"""
                TextBlock.fontFamily (new FontFamily("Consolas"))
            ]
        Border.create [
            Border.background "lightgray"
            Border.cornerRadius 4
            Border.padding (Thickness 10)
            Border.child c
        ]

    let private regular = 
        let c = 
            TextBlock.create [
                TextBlock.text "Regular border"
                TextBlock.padding (Thickness 5)
            ]
        Border.create [
            Border.borderBrush "black"
            Border.borderThickness 1
            Border.child c
        ]

    let private thick = 
        let c = 
            TextBlock.create [
                TextBlock.text "Thick border"
                TextBlock.padding (Thickness 5)
            ]
        Border.create [
            Border.borderBrush "black"
            Border.borderThickness 4
            Border.child c
        ]

    let private ants = 
        let avlist = new Collections.AvaloniaList<float>(1,1)
        let mutable r = new Rectangle()
        r.StrokeDashArray <- avlist
        r.StrokeThickness <- 3
        r.Stroke <- Brushes.Blue
        r.Height <- 40
        r.Width <- 100
        let mutable vb = new VisualBrush()
        vb.Visual <- r
        
        let c = 
            TextBlock.create [
                TextBlock.text "Ants border"
                TextBlock.padding (Thickness 5)
            ]

        let x = new Border.BorderDashArrayProperty
        Border.create [
            
            Border.child r
        ]

    let private boxshadow = 
        let c = 
            TextBlock.create [ 
                TextBlock.text "Drop Shadow" 
            ]
        let mutable bs = new BoxShadow()
        bs.Blur <- 10.0
        bs.Color <- Avalonia.Media.Colors.LightGray
        //bs.OffsetX <- 2.0
        //bs.OffsetY <- 2.0

        Border.create [
            Border.boxShadow bs
            Border.cornerRadius 4
            Border.padding (Thickness(10,5))
            Border.child c
        ]

    let GetBorders = 
        DockPanel.create [
            DockPanel.children [
                StackPanel.create [
                    StackPanel.orientation Orientation.Horizontal
                    StackPanel.verticalAlignment VerticalAlignment.Top
                    StackPanel.spacing 8.0
                    StackPanel.margin 2
                    StackPanel.children [
                        regular
                        thick
                        codeBlock
                        boxshadow
                        ants
                    ]
                ]
            ]
        ]

