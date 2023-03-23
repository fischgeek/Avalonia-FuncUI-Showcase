namespace AvaloniaFuncUIShowcase

open Avalonia.Controls
open Avalonia.FuncUI.DSL
open Avalonia.Layout

module Buttons = 
    let private standardButton = 
        Button.create [
            Button.content "Standard button"
        ]

    let private buttonWithIcon = 
        let i = new Avalonia.Media.Imaging.Bitmap("assets/search.png")
        let x = 
            StackPanel.create [
                StackPanel.orientation Orientation.Horizontal
                StackPanel.spacing 8.0
                StackPanel.children [
                    TextBlock.create [ TextBlock.text "Button with Icon"]
                    Image.create [ 
                        Image.source i 
                        Image.width 20
                    ]
                ]
            ]
        Button.create [
            Button.content x
        ]

    let private bootstrabBtn (name: string) (bg: string) (fg: string) = 
        Button.create [
            Button.background bg
            Button.foreground fg
            Button.content name
        ]

    let GetButtons = 
        DockPanel.create [
            DockPanel.dock Dock.Top
            DockPanel.children [
                StackPanel.create [
                    StackPanel.dock Dock.Top
                    StackPanel.verticalAlignment VerticalAlignment.Top
                    StackPanel.orientation Orientation.Horizontal
                    StackPanel.children [
                        bootstrabBtn "Primary" "#0d6efd" "white"
                        bootstrabBtn "Secondary" "#6c757d" "white"
                        bootstrabBtn "Success" "#198754" "white"
                        bootstrabBtn "Danger" "#dc3545" "white"
                        bootstrabBtn "Info" "#0dcaf0" "white"
                        standardButton
                        buttonWithIcon
                    ]
                ]
            ]
        ]

