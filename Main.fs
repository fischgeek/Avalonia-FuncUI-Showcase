namespace AvaloniaFuncUIShowcase

open Avalonia.FuncUI.Types
open Avalonia.Controls
open Avalonia.FuncUI.DSL
open Avalonia
open Avalonia.Controls
open Avalonia.Controls

module Main =
    
    type State = { count : int }
    let init = { count = 0 }

    type Msg = Increment | Decrement | Reset

    let update (msg: Msg) (state: State) : State =
        match msg with
        | Increment -> { state with count = state.count + 1 }
        | Decrement -> { state with count = state.count - 1 }
        | Reset -> init       
    
    let createTabItem (name: string) (content: IView<DockPanel>) = 
        TabItem.create [
            TabItem.header name
            TabItem.content content
        ]

    let tabs : IView list = [
        createTabItem "Home" Home.GetHomeContent
        createTabItem "About" About.GetAboutContent
        createTabItem "Buttons" Buttons.GetButtons
        createTabItem "Borders" Borders.GetBorders
    ]

    let view (state: State) (dispatch) =
        DockPanel.create [
            DockPanel.margin (Thickness 0)
            DockPanel.children [
                TabControl.create [
                    TabControl.tabStripPlacement Dock.Left
                    TabControl.viewItems tabs
                ]
            ]
        ]