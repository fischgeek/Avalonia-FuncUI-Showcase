namespace AvaloniaFuncUIShowcase

open Avalonia.FuncUI.Types
open Avalonia.Controls
open Avalonia.FuncUI.DSL
open Avalonia
open Avalonia.Controls
open Avalonia.Controls

module Home = 
    let GetHomeContent = 
        DockPanel.create [ 
            DockPanel.children [
                TextBlock.create [ TextBlock.text "Home" ]
            ]
        ]

