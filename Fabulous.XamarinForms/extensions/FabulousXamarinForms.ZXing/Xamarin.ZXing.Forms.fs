// Copyright 2018-2020 Fabulous contributors. See LICENSE.md for license.
namespace Fabulous.XamarinForms.ZXing

#nowarn "59" // cast always holds
#nowarn "66" // cast always holds
#nowarn "67" // cast always holds
#nowarn "760"

open Fabulous
open Fabulous.XamarinForms

module ViewAttributes =
    let OnScanResultAttribKey : AttributeKey<_> = AttributeKey<_>("OnScanResult")
    let AutoFocusRequestedAttribKey : AttributeKey<_> = AttributeKey<_>("AutoFocusRequested")
    let IsScanningAttribKey : AttributeKey<_> = AttributeKey<_>("IsScanning")
    let IsTorchOnAttribKey : AttributeKey<_> = AttributeKey<_>("IsTorchOn")
    let IsAnalyzingAttribKey : AttributeKey<_> = AttributeKey<_>("IsAnalyzing")
    let ResultAttribKey : AttributeKey<_> = AttributeKey<_>("Result")
    let ScanResultCommandAttribKey : AttributeKey<_> = AttributeKey<_>("ScanResultCommand")
    let ScanResultCommandCanExecuteAttribKey : AttributeKey<_> = AttributeKey<_>("ScanResultCommandCanExecute")

type ViewBuilders() =
    /// Builds the attributes for a ZXingScannerView in the view
    static member inline BuildZXingScannerView(attribCount: int,
                                               ?isScanning: bool,
                                               ?isTorchOn: bool,
                                               ?isAnalyzing: bool,
                                               ?result: ZXing.Result,
                                               ?scanResultCommand: unit -> unit,
                                               ?scanResultCommandCanExecute: bool,
                                               ?gestureRecognizers: ViewElement list,
                                               ?horizontalOptions: Xamarin.Forms.LayoutOptions,
                                               ?margin: Xamarin.Forms.Thickness,
                                               ?verticalOptions: Xamarin.Forms.LayoutOptions,
                                               ?anchorX: float,
                                               ?anchorY: float,
                                               ?background: ViewElement,
                                               ?backgroundColor: Xamarin.Forms.Color,
                                               ?behaviors: ViewElement list,
                                               ?clip: ViewElement,
                                               ?flowDirection: Xamarin.Forms.FlowDirection,
                                               ?height: float,
                                               ?inputTransparent: bool,
                                               ?isEnabled: bool,
                                               ?isTabStop: bool,
                                               ?isVisible: bool,
                                               ?minimumHeight: float,
                                               ?minimumWidth: float,
                                               ?opacity: float,
                                               ?resources: (string * obj) list,
                                               ?rotation: float,
                                               ?rotationX: float,
                                               ?rotationY: float,
                                               ?scale: float,
                                               ?scaleX: float,
                                               ?scaleY: float,
                                               ?styles: Xamarin.Forms.Style list,
                                               ?styleSheets: Xamarin.Forms.StyleSheets.StyleSheet list,
                                               ?tabIndex: int,
                                               ?translationX: float,
                                               ?translationY: float,
                                               ?visual: Xamarin.Forms.IVisual,
                                               ?width: float,
                                               ?style: Xamarin.Forms.Style,
                                               ?styleClasses: string list,
                                               ?shellBackButtonBehavior: ViewElement,
                                               ?shellBackgroundColor: Xamarin.Forms.Color,
                                               ?shellDisabledColor: Xamarin.Forms.Color,
                                               ?shellForegroundColor: Xamarin.Forms.Color,
                                               ?shellFlyoutBehavior: Xamarin.Forms.FlyoutBehavior,
                                               ?shellNavBarIsVisible: bool,
                                               ?shellPresentationMode: Xamarin.Forms.PresentationMode,
                                               ?shellSearchHandler: ViewElement,
                                               ?shellTabBarBackgroundColor: Xamarin.Forms.Color,
                                               ?shellTabBarDisabledColor: Xamarin.Forms.Color,
                                               ?shellTabBarForegroundColor: Xamarin.Forms.Color,
                                               ?shellTabBarIsVisible: bool,
                                               ?shellTabBarTitleColor: Xamarin.Forms.Color,
                                               ?shellTabBarUnselectedColor: Xamarin.Forms.Color,
                                               ?shellTitleColor: Xamarin.Forms.Color,
                                               ?shellTitleView: ViewElement,
                                               ?shellUnselectedColor: Xamarin.Forms.Color,
                                               ?shellNavBarHasShadow: bool,
                                               ?automationId: string,
                                               ?classId: string,
                                               ?effects: ViewElement list,
                                               ?menu: ViewElement,
                                               ?styleId: string,
                                               ?ref: ViewRef,
                                               ?key: string,
                                               ?tag: obj,
                                               ?onScanResult: unit -> unit,
                                               ?autoFocusRequested: int -> unit,
                                               ?focused: Xamarin.Forms.FocusEventArgs -> unit,
                                               ?sizeChanged: float * float -> unit,
                                               ?unfocused: Xamarin.Forms.FocusEventArgs -> unit,
                                               ?created: obj -> unit) = 

        let attribCount = match isScanning with Some _ -> attribCount + 1 | None -> attribCount
        let attribCount = match isTorchOn with Some _ -> attribCount + 1 | None -> attribCount
        let attribCount = match isAnalyzing with Some _ -> attribCount + 1 | None -> attribCount
        let attribCount = match result with Some _ -> attribCount + 1 | None -> attribCount
        let attribCount = match scanResultCommand with Some _ -> attribCount + 1 | None -> attribCount
        let attribCount = match scanResultCommandCanExecute with Some _ -> attribCount + 1 | None -> attribCount
        let attribCount = match onScanResult with Some _ -> attribCount + 1 | None -> attribCount
        let attribCount = match autoFocusRequested with Some _ -> attribCount + 1 | None -> attribCount

        let attribBuilder = ViewBuilders.BuildView(attribCount, ?gestureRecognizers=gestureRecognizers, ?horizontalOptions=horizontalOptions, ?margin=margin, ?verticalOptions=verticalOptions, ?anchorX=anchorX, 
                                                   ?anchorY=anchorY, ?background=background, ?backgroundColor=backgroundColor, ?behaviors=behaviors, ?clip=clip, 
                                                   ?flowDirection=flowDirection, ?height=height, ?inputTransparent=inputTransparent, ?isEnabled=isEnabled, ?isTabStop=isTabStop, 
                                                   ?isVisible=isVisible, ?minimumHeight=minimumHeight, ?minimumWidth=minimumWidth, ?opacity=opacity, ?resources=resources, 
                                                   ?rotation=rotation, ?rotationX=rotationX, ?rotationY=rotationY, ?scale=scale, ?scaleX=scaleX, 
                                                   ?scaleY=scaleY, ?styles=styles, ?styleSheets=styleSheets, ?tabIndex=tabIndex, ?translationX=translationX, 
                                                   ?translationY=translationY, ?visual=visual, ?width=width, ?style=style, ?styleClasses=styleClasses, 
                                                   ?shellBackButtonBehavior=shellBackButtonBehavior, ?shellBackgroundColor=shellBackgroundColor, ?shellDisabledColor=shellDisabledColor, ?shellForegroundColor=shellForegroundColor, ?shellFlyoutBehavior=shellFlyoutBehavior, 
                                                   ?shellNavBarIsVisible=shellNavBarIsVisible, ?shellPresentationMode=shellPresentationMode, ?shellSearchHandler=shellSearchHandler, ?shellTabBarBackgroundColor=shellTabBarBackgroundColor, ?shellTabBarDisabledColor=shellTabBarDisabledColor, 
                                                   ?shellTabBarForegroundColor=shellTabBarForegroundColor, ?shellTabBarIsVisible=shellTabBarIsVisible, ?shellTabBarTitleColor=shellTabBarTitleColor, ?shellTabBarUnselectedColor=shellTabBarUnselectedColor, ?shellTitleColor=shellTitleColor, 
                                                   ?shellTitleView=shellTitleView, ?shellUnselectedColor=shellUnselectedColor, ?shellNavBarHasShadow=shellNavBarHasShadow, ?automationId=automationId, ?classId=classId, 
                                                   ?effects=effects, ?menu=menu, ?styleId=styleId, ?ref=ref, ?key=key, 
                                                   ?tag=tag, ?focused=focused, ?sizeChanged=sizeChanged, ?unfocused=unfocused, ?created=created)
        match isScanning with None -> () | Some v -> attribBuilder.Add(ViewAttributes.IsScanningAttribKey, (v)) 
        match isTorchOn with None -> () | Some v -> attribBuilder.Add(ViewAttributes.IsTorchOnAttribKey, (v)) 
        match isAnalyzing with None -> () | Some v -> attribBuilder.Add(ViewAttributes.IsAnalyzingAttribKey, (v)) 
        match result with None -> () | Some v -> attribBuilder.Add(ViewAttributes.ResultAttribKey, (v)) 
        match scanResultCommand with None -> () | Some v -> attribBuilder.Add(ViewAttributes.ScanResultCommandAttribKey, (v)) 
        match scanResultCommandCanExecute with None -> () | Some v -> attribBuilder.Add(ViewAttributes.ScanResultCommandCanExecuteAttribKey, (v)) 
        match onScanResult with None -> () | Some v -> attribBuilder.Add(ViewAttributes.OnScanResultAttribKey, (fun f -> System.EventHandler(fun _sender _args -> f()))(v)) 
        match autoFocusRequested with None -> () | Some v -> attribBuilder.Add(ViewAttributes.AutoFocusRequestedAttribKey, (fun f -> System.EventHandler<int>(fun _sender _args -> f _args))(v)) 
        attribBuilder

    static member CreateZXingScannerView () : ZXing.Net.Mobile.Forms.ZXingScannerView =
        ZXing.Net.Mobile.Forms.ZXingScannerView()

    static member UpdateZXingScannerView (registry: System.Collections.Generic.Dictionary<int, ViewElement voption -> ViewElement -> obj -> unit>, prevOpt: ViewElement voption, curr: ViewElement, target: ZXing.Net.Mobile.Forms.ZXingScannerView) = 
        let mutable prevOnScanResultOpt = ValueNone
        let mutable currOnScanResultOpt = ValueNone
        let mutable prevAutoFocusRequestedOpt = ValueNone
        let mutable currAutoFocusRequestedOpt = ValueNone
        let mutable prevIsScanningOpt = ValueNone
        let mutable currIsScanningOpt = ValueNone
        let mutable prevIsTorchOnOpt = ValueNone
        let mutable currIsTorchOnOpt = ValueNone
        let mutable prevIsAnalyzingOpt = ValueNone
        let mutable currIsAnalyzingOpt = ValueNone
        let mutable prevResultOpt = ValueNone
        let mutable currResultOpt = ValueNone
        let mutable prevScanResultCommandOpt = ValueNone
        let mutable currScanResultCommandOpt = ValueNone
        let mutable prevScanResultCommandCanExecuteOpt = ValueNone
        let mutable currScanResultCommandCanExecuteOpt = ValueNone
        for kvp in curr.AttributesKeyed do
            if kvp.Key = ViewAttributes.OnScanResultAttribKey.KeyValue then 
                currOnScanResultOpt <- ValueSome (kvp.Value :?> ZXing.Net.Mobile.Forms.ZXingScannerView.ScanResultDelegate)
            if kvp.Key = ViewAttributes.AutoFocusRequestedAttribKey.KeyValue then 
                currAutoFocusRequestedOpt <- ValueSome (kvp.Value :?> System.Action<System.Int32,System.Int32>)
            if kvp.Key = ViewAttributes.IsScanningAttribKey.KeyValue then 
                currIsScanningOpt <- ValueSome (kvp.Value :?> bool)
            if kvp.Key = ViewAttributes.IsTorchOnAttribKey.KeyValue then 
                currIsTorchOnOpt <- ValueSome (kvp.Value :?> bool)
            if kvp.Key = ViewAttributes.IsAnalyzingAttribKey.KeyValue then 
                currIsAnalyzingOpt <- ValueSome (kvp.Value :?> bool)
            if kvp.Key = ViewAttributes.ResultAttribKey.KeyValue then 
                currResultOpt <- ValueSome (kvp.Value :?> ZXing.Result)
            if kvp.Key = ViewAttributes.ScanResultCommandAttribKey.KeyValue then 
                currScanResultCommandOpt <- ValueSome (kvp.Value :?> unit -> unit)
            if kvp.Key = ViewAttributes.ScanResultCommandCanExecuteAttribKey.KeyValue then 
                currScanResultCommandCanExecuteOpt <- ValueSome (kvp.Value :?> bool)
        match prevOpt with
        | ValueNone -> ()
        | ValueSome prev ->
            for kvp in prev.AttributesKeyed do
                if kvp.Key = ViewAttributes.OnScanResultAttribKey.KeyValue then 
                    prevOnScanResultOpt <- ValueSome (kvp.Value :?> ZXing.Net.Mobile.Forms.ZXingScannerView.ScanResultDelegate)
                if kvp.Key = ViewAttributes.AutoFocusRequestedAttribKey.KeyValue then 
                    prevAutoFocusRequestedOpt <- ValueSome (kvp.Value :?> System.Action<System.Int32,System.Int32>)
                if kvp.Key = ViewAttributes.IsScanningAttribKey.KeyValue then 
                    prevIsScanningOpt <- ValueSome (kvp.Value :?> bool)
                if kvp.Key = ViewAttributes.IsTorchOnAttribKey.KeyValue then 
                    prevIsTorchOnOpt <- ValueSome (kvp.Value :?> bool)
                if kvp.Key = ViewAttributes.IsAnalyzingAttribKey.KeyValue then 
                    prevIsAnalyzingOpt <- ValueSome (kvp.Value :?> bool)
                if kvp.Key = ViewAttributes.ResultAttribKey.KeyValue then 
                    prevResultOpt <- ValueSome (kvp.Value :?> ZXing.Result)
                if kvp.Key = ViewAttributes.ScanResultCommandAttribKey.KeyValue then 
                    prevScanResultCommandOpt <- ValueSome (kvp.Value :?> unit -> unit)
                if kvp.Key = ViewAttributes.ScanResultCommandCanExecuteAttribKey.KeyValue then 
                    prevScanResultCommandCanExecuteOpt <- ValueSome (kvp.Value :?> bool)
        // Unsubscribe previous event handlers
        let shouldUpdateOnScanResult = not ((identical prevOnScanResultOpt currOnScanResultOpt))
        if shouldUpdateOnScanResult then
            match prevOnScanResultOpt with
            | ValueSome prevValue -> target.remove_OnScanResult (prevValue )
            | ValueNone -> ()
        let shouldUpdateAutoFocusRequested = not ((identical prevAutoFocusRequestedOpt currAutoFocusRequestedOpt))
        if shouldUpdateAutoFocusRequested then
            match prevAutoFocusRequestedOpt with
            | ValueSome prevValue -> target.remove_AutoFocusRequested (prevValue)
            | ValueNone -> ()
        // Update inherited members
        ViewBuilders.UpdateView (registry, prevOpt, curr, target)
        // Update properties
        match prevIsScanningOpt, currIsScanningOpt with
        | ValueSome prevValue, ValueSome currValue when prevValue = currValue -> ()
        | _, ValueSome currValue -> target.IsScanning <-  currValue
        | ValueSome _, ValueNone -> target.ClearValue ZXing.Net.Mobile.Forms.ZXingScannerView.IsScanningProperty
        | ValueNone, ValueNone -> ()
        match prevIsTorchOnOpt, currIsTorchOnOpt with
        | ValueSome prevValue, ValueSome currValue when prevValue = currValue -> ()
        | _, ValueSome currValue -> target.IsTorchOn <-  currValue
        | ValueSome _, ValueNone -> target.ClearValue ZXing.Net.Mobile.Forms.ZXingScannerView.IsTorchOnProperty
        | ValueNone, ValueNone -> ()
        match prevIsAnalyzingOpt, currIsAnalyzingOpt with
        | ValueSome prevValue, ValueSome currValue when prevValue = currValue -> ()
        | _, ValueSome currValue -> target.IsAnalyzing <-  currValue
        | ValueSome _, ValueNone -> target.ClearValue ZXing.Net.Mobile.Forms.ZXingScannerView.IsAnalyzingProperty
        | ValueNone, ValueNone -> ()
        match prevResultOpt, currResultOpt with
        | ValueSome prevValue, ValueSome currValue when prevValue = currValue -> ()
        | _, ValueSome currValue -> target.Result <-  currValue
        | ValueSome _, ValueNone -> target.ClearValue ZXing.Net.Mobile.Forms.ZXingScannerView.ResultProperty
        | ValueNone, ValueNone -> ()
        (fun _ _ _ -> ()) prevScanResultCommandOpt currScanResultCommandOpt target
        ViewUpdaters.updateCommand prevScanResultCommandOpt currScanResultCommandOpt (fun _target -> ()) (fun (target: ZXing.Net.Mobile.Forms.ZXingScannerView) cmd -> target.ScanResultCommand <- cmd) prevScanResultCommandCanExecuteOpt currScanResultCommandCanExecuteOpt target
        // Subscribe new event handlers
        if shouldUpdateOnScanResult then
            match currOnScanResultOpt with
            | ValueSome currValue -> target.add_OnScanResult(currValue)
            | ValueNone -> ()
        if shouldUpdateAutoFocusRequested then
            match currAutoFocusRequestedOpt with
            | ValueSome currValue -> target.add_AutoFocusRequested(currValue)
            | ValueNone -> ()

    static member inline ConstructZXingScannerView(?isScanning: bool,
                                                   ?isTorchOn: bool,
                                                   ?isAnalyzing: bool,
                                                   ?result: ZXing.Result,
                                                   ?scanResultCommand: unit -> unit,
                                                   ?scanResultCommandCanExecute: bool,
                                                   ?gestureRecognizers: ViewElement list,
                                                   ?horizontalOptions: Xamarin.Forms.LayoutOptions,
                                                   ?margin: Xamarin.Forms.Thickness,
                                                   ?verticalOptions: Xamarin.Forms.LayoutOptions,
                                                   ?anchorX: float,
                                                   ?anchorY: float,
                                                   ?background: ViewElement,
                                                   ?backgroundColor: Xamarin.Forms.Color,
                                                   ?behaviors: ViewElement list,
                                                   ?clip: ViewElement,
                                                   ?flowDirection: Xamarin.Forms.FlowDirection,
                                                   ?height: float,
                                                   ?inputTransparent: bool,
                                                   ?isEnabled: bool,
                                                   ?isTabStop: bool,
                                                   ?isVisible: bool,
                                                   ?minimumHeight: float,
                                                   ?minimumWidth: float,
                                                   ?opacity: float,
                                                   ?resources: (string * obj) list,
                                                   ?rotation: float,
                                                   ?rotationX: float,
                                                   ?rotationY: float,
                                                   ?scale: float,
                                                   ?scaleX: float,
                                                   ?scaleY: float,
                                                   ?styles: Xamarin.Forms.Style list,
                                                   ?styleSheets: Xamarin.Forms.StyleSheets.StyleSheet list,
                                                   ?tabIndex: int,
                                                   ?translationX: float,
                                                   ?translationY: float,
                                                   ?visual: Xamarin.Forms.IVisual,
                                                   ?width: float,
                                                   ?style: Xamarin.Forms.Style,
                                                   ?styleClasses: string list,
                                                   ?shellBackButtonBehavior: ViewElement,
                                                   ?shellBackgroundColor: Xamarin.Forms.Color,
                                                   ?shellDisabledColor: Xamarin.Forms.Color,
                                                   ?shellForegroundColor: Xamarin.Forms.Color,
                                                   ?shellFlyoutBehavior: Xamarin.Forms.FlyoutBehavior,
                                                   ?shellNavBarIsVisible: bool,
                                                   ?shellPresentationMode: Xamarin.Forms.PresentationMode,
                                                   ?shellSearchHandler: ViewElement,
                                                   ?shellTabBarBackgroundColor: Xamarin.Forms.Color,
                                                   ?shellTabBarDisabledColor: Xamarin.Forms.Color,
                                                   ?shellTabBarForegroundColor: Xamarin.Forms.Color,
                                                   ?shellTabBarIsVisible: bool,
                                                   ?shellTabBarTitleColor: Xamarin.Forms.Color,
                                                   ?shellTabBarUnselectedColor: Xamarin.Forms.Color,
                                                   ?shellTitleColor: Xamarin.Forms.Color,
                                                   ?shellTitleView: ViewElement,
                                                   ?shellUnselectedColor: Xamarin.Forms.Color,
                                                   ?shellNavBarHasShadow: bool,
                                                   ?automationId: string,
                                                   ?classId: string,
                                                   ?effects: ViewElement list,
                                                   ?menu: ViewElement,
                                                   ?styleId: string,
                                                   ?ref: ViewRef<ZXing.Net.Mobile.Forms.ZXingScannerView>,
                                                   ?key: string,
                                                   ?tag: obj,
                                                   ?onScanResult: unit -> unit,
                                                   ?autoFocusRequested: int -> unit,
                                                   ?focused: Xamarin.Forms.FocusEventArgs -> unit,
                                                   ?sizeChanged: float * float -> unit,
                                                   ?unfocused: Xamarin.Forms.FocusEventArgs -> unit,
                                                   ?created: (ZXing.Net.Mobile.Forms.ZXingScannerView -> unit)) = 

        let attribBuilder = ViewBuilders.BuildZXingScannerView(0,
                               ?isScanning=isScanning,
                               ?isTorchOn=isTorchOn,
                               ?isAnalyzing=isAnalyzing,
                               ?result=result,
                               ?scanResultCommand=scanResultCommand,
                               ?scanResultCommandCanExecute=scanResultCommandCanExecute,
                               ?gestureRecognizers=gestureRecognizers,
                               ?horizontalOptions=horizontalOptions,
                               ?margin=margin,
                               ?verticalOptions=verticalOptions,
                               ?anchorX=anchorX,
                               ?anchorY=anchorY,
                               ?background=background,
                               ?backgroundColor=backgroundColor,
                               ?behaviors=behaviors,
                               ?clip=clip,
                               ?flowDirection=flowDirection,
                               ?height=height,
                               ?inputTransparent=inputTransparent,
                               ?isEnabled=isEnabled,
                               ?isTabStop=isTabStop,
                               ?isVisible=isVisible,
                               ?minimumHeight=minimumHeight,
                               ?minimumWidth=minimumWidth,
                               ?opacity=opacity,
                               ?resources=resources,
                               ?rotation=rotation,
                               ?rotationX=rotationX,
                               ?rotationY=rotationY,
                               ?scale=scale,
                               ?scaleX=scaleX,
                               ?scaleY=scaleY,
                               ?styles=styles,
                               ?styleSheets=styleSheets,
                               ?tabIndex=tabIndex,
                               ?translationX=translationX,
                               ?translationY=translationY,
                               ?visual=visual,
                               ?width=width,
                               ?style=style,
                               ?styleClasses=styleClasses,
                               ?shellBackButtonBehavior=shellBackButtonBehavior,
                               ?shellBackgroundColor=shellBackgroundColor,
                               ?shellDisabledColor=shellDisabledColor,
                               ?shellForegroundColor=shellForegroundColor,
                               ?shellFlyoutBehavior=shellFlyoutBehavior,
                               ?shellNavBarIsVisible=shellNavBarIsVisible,
                               ?shellPresentationMode=shellPresentationMode,
                               ?shellSearchHandler=shellSearchHandler,
                               ?shellTabBarBackgroundColor=shellTabBarBackgroundColor,
                               ?shellTabBarDisabledColor=shellTabBarDisabledColor,
                               ?shellTabBarForegroundColor=shellTabBarForegroundColor,
                               ?shellTabBarIsVisible=shellTabBarIsVisible,
                               ?shellTabBarTitleColor=shellTabBarTitleColor,
                               ?shellTabBarUnselectedColor=shellTabBarUnselectedColor,
                               ?shellTitleColor=shellTitleColor,
                               ?shellTitleView=shellTitleView,
                               ?shellUnselectedColor=shellUnselectedColor,
                               ?shellNavBarHasShadow=shellNavBarHasShadow,
                               ?automationId=automationId,
                               ?classId=classId,
                               ?effects=effects,
                               ?menu=menu,
                               ?styleId=styleId,
                               ?ref=(match ref with None -> None | Some (ref: ViewRef<ZXing.Net.Mobile.Forms.ZXingScannerView>) -> Some ref.Unbox),
                               ?key=key,
                               ?tag=tag,
                               ?onScanResult=onScanResult,
                               ?autoFocusRequested=autoFocusRequested,
                               ?focused=focused,
                               ?sizeChanged=sizeChanged,
                               ?unfocused=unfocused,
                               ?created=(match created with None -> None | Some createdFunc -> Some (fun (target: obj) ->  createdFunc (unbox<ZXing.Net.Mobile.Forms.ZXingScannerView> target))))

        ViewElement.Create<ZXing.Net.Mobile.Forms.ZXingScannerView>(ViewBuilders.CreateZXingScannerView, (fun registry prevOpt curr target -> ViewBuilders.UpdateZXingScannerView(registry, prevOpt, curr, target)), attribBuilder)

/// Viewer that allows to read the properties of a ViewElement representing a ZXingScannerView
type ZXingScannerViewViewer(element: ViewElement) =
    inherit ViewViewer(element)
    do if not ((typeof<ZXing.Net.Mobile.Forms.ZXingScannerView>).IsAssignableFrom(element.TargetType)) then failwithf "A ViewElement assignable to type 'ZXing.Net.Mobile.Forms.ZXingScannerView' is expected, but '%s' was provided." element.TargetType.FullName
    /// Get the value of the IsScanning member
    member this.IsScanning = element.GetAttributeKeyed(ViewAttributes.IsScanningAttribKey)
    /// Get the value of the IsTorchOn member
    member this.IsTorchOn = element.GetAttributeKeyed(ViewAttributes.IsTorchOnAttribKey)
    /// Get the value of the IsAnalyzing member
    member this.IsAnalyzing = element.GetAttributeKeyed(ViewAttributes.IsAnalyzingAttribKey)
    /// Get the value of the Result member
    member this.Result = element.GetAttributeKeyed(ViewAttributes.ResultAttribKey)
    /// Get the value of the ScanResultCommand member
    member this.ScanResultCommand = element.GetAttributeKeyed(ViewAttributes.ScanResultCommandAttribKey)
    /// Get the value of the ScanResultCommandCanExecute member
    member this.ScanResultCommandCanExecute = element.GetAttributeKeyed(ViewAttributes.ScanResultCommandCanExecuteAttribKey)
    /// Get the value of the OnScanResult member
    member this.OnScanResult = element.GetAttributeKeyed(ViewAttributes.OnScanResultAttribKey)
    /// Get the value of the AutoFocusRequested member
    member this.AutoFocusRequested = element.GetAttributeKeyed(ViewAttributes.AutoFocusRequestedAttribKey)

[<AbstractClass; Sealed>]
type View private () =
    /// Describes a ZXingScannerView in the view
    static member inline ZXingScannerView(?anchorX: float,
                                          ?anchorY: float,
                                          ?autoFocusRequested: int -> unit,
                                          ?automationId: string,
                                          ?background: ViewElement,
                                          ?backgroundColor: Xamarin.Forms.Color,
                                          ?behaviors: ViewElement list,
                                          ?classId: string,
                                          ?clip: ViewElement,
                                          ?created: (ZXing.Net.Mobile.Forms.ZXingScannerView -> unit),
                                          ?effects: ViewElement list,
                                          ?flowDirection: Xamarin.Forms.FlowDirection,
                                          ?focused: Xamarin.Forms.FocusEventArgs -> unit,
                                          ?gestureRecognizers: ViewElement list,
                                          ?height: float,
                                          ?horizontalOptions: Xamarin.Forms.LayoutOptions,
                                          ?inputTransparent: bool,
                                          ?isAnalyzing: bool,
                                          ?isEnabled: bool,
                                          ?isScanning: bool,
                                          ?isTabStop: bool,
                                          ?isTorchOn: bool,
                                          ?isVisible: bool,
                                          ?key: string,
                                          ?margin: Xamarin.Forms.Thickness,
                                          ?menu: ViewElement,
                                          ?minimumHeight: float,
                                          ?minimumWidth: float,
                                          ?onScanResult: unit -> unit,
                                          ?opacity: float,
                                          ?ref: ViewRef<ZXing.Net.Mobile.Forms.ZXingScannerView>,
                                          ?resources: (string * obj) list,
                                          ?result: ZXing.Result,
                                          ?rotation: float,
                                          ?rotationX: float,
                                          ?rotationY: float,
                                          ?scale: float,
                                          ?scaleX: float,
                                          ?scaleY: float,
                                          ?scanResultCommand: unit -> unit,
                                          ?scanResultCommandCanExecute: bool,
                                          ?shellBackButtonBehavior: ViewElement,
                                          ?shellBackgroundColor: Xamarin.Forms.Color,
                                          ?shellDisabledColor: Xamarin.Forms.Color,
                                          ?shellFlyoutBehavior: Xamarin.Forms.FlyoutBehavior,
                                          ?shellForegroundColor: Xamarin.Forms.Color,
                                          ?shellNavBarHasShadow: bool,
                                          ?shellNavBarIsVisible: bool,
                                          ?shellPresentationMode: Xamarin.Forms.PresentationMode,
                                          ?shellSearchHandler: ViewElement,
                                          ?shellTabBarBackgroundColor: Xamarin.Forms.Color,
                                          ?shellTabBarDisabledColor: Xamarin.Forms.Color,
                                          ?shellTabBarForegroundColor: Xamarin.Forms.Color,
                                          ?shellTabBarIsVisible: bool,
                                          ?shellTabBarTitleColor: Xamarin.Forms.Color,
                                          ?shellTabBarUnselectedColor: Xamarin.Forms.Color,
                                          ?shellTitleColor: Xamarin.Forms.Color,
                                          ?shellTitleView: ViewElement,
                                          ?shellUnselectedColor: Xamarin.Forms.Color,
                                          ?sizeChanged: float * float -> unit,
                                          ?style: Xamarin.Forms.Style,
                                          ?styleClasses: string list,
                                          ?styleId: string,
                                          ?styleSheets: Xamarin.Forms.StyleSheets.StyleSheet list,
                                          ?styles: Xamarin.Forms.Style list,
                                          ?tabIndex: int,
                                          ?tag: obj,
                                          ?translationX: float,
                                          ?translationY: float,
                                          ?unfocused: Xamarin.Forms.FocusEventArgs -> unit,
                                          ?verticalOptions: Xamarin.Forms.LayoutOptions,
                                          ?visual: Xamarin.Forms.IVisual,
                                          ?width: float) =

        ViewBuilders.ConstructZXingScannerView(?anchorX=anchorX,
                               ?anchorY=anchorY,
                               ?autoFocusRequested=autoFocusRequested,
                               ?automationId=automationId,
                               ?background=background,
                               ?backgroundColor=backgroundColor,
                               ?behaviors=behaviors,
                               ?classId=classId,
                               ?clip=clip,
                               ?created=created,
                               ?effects=effects,
                               ?flowDirection=flowDirection,
                               ?focused=focused,
                               ?gestureRecognizers=gestureRecognizers,
                               ?height=height,
                               ?horizontalOptions=horizontalOptions,
                               ?inputTransparent=inputTransparent,
                               ?isAnalyzing=isAnalyzing,
                               ?isEnabled=isEnabled,
                               ?isScanning=isScanning,
                               ?isTabStop=isTabStop,
                               ?isTorchOn=isTorchOn,
                               ?isVisible=isVisible,
                               ?key=key,
                               ?margin=margin,
                               ?menu=menu,
                               ?minimumHeight=minimumHeight,
                               ?minimumWidth=minimumWidth,
                               ?onScanResult=onScanResult,
                               ?opacity=opacity,
                               ?ref=ref,
                               ?resources=resources,
                               ?result=result,
                               ?rotation=rotation,
                               ?rotationX=rotationX,
                               ?rotationY=rotationY,
                               ?scale=scale,
                               ?scaleX=scaleX,
                               ?scaleY=scaleY,
                               ?scanResultCommand=scanResultCommand,
                               ?scanResultCommandCanExecute=scanResultCommandCanExecute,
                               ?shellBackButtonBehavior=shellBackButtonBehavior,
                               ?shellBackgroundColor=shellBackgroundColor,
                               ?shellDisabledColor=shellDisabledColor,
                               ?shellFlyoutBehavior=shellFlyoutBehavior,
                               ?shellForegroundColor=shellForegroundColor,
                               ?shellNavBarHasShadow=shellNavBarHasShadow,
                               ?shellNavBarIsVisible=shellNavBarIsVisible,
                               ?shellPresentationMode=shellPresentationMode,
                               ?shellSearchHandler=shellSearchHandler,
                               ?shellTabBarBackgroundColor=shellTabBarBackgroundColor,
                               ?shellTabBarDisabledColor=shellTabBarDisabledColor,
                               ?shellTabBarForegroundColor=shellTabBarForegroundColor,
                               ?shellTabBarIsVisible=shellTabBarIsVisible,
                               ?shellTabBarTitleColor=shellTabBarTitleColor,
                               ?shellTabBarUnselectedColor=shellTabBarUnselectedColor,
                               ?shellTitleColor=shellTitleColor,
                               ?shellTitleView=shellTitleView,
                               ?shellUnselectedColor=shellUnselectedColor,
                               ?sizeChanged=sizeChanged,
                               ?style=style,
                               ?styleClasses=styleClasses,
                               ?styleId=styleId,
                               ?styleSheets=styleSheets,
                               ?styles=styles,
                               ?tabIndex=tabIndex,
                               ?tag=tag,
                               ?translationX=translationX,
                               ?translationY=translationY,
                               ?unfocused=unfocused,
                               ?verticalOptions=verticalOptions,
                               ?visual=visual,
                               ?width=width)


[<AutoOpen>]
module ViewElementExtensions = 

    type ViewElement with

        /// Adjusts the OnScanResult property in the visual element
        member x.OnScanResult(value: unit -> unit) = x.WithAttribute(ViewAttributes.OnScanResultAttribKey, (fun f -> System.EventHandler(fun _sender _args -> f()))(value))

        /// Adjusts the AutoFocusRequested property in the visual element
        member x.AutoFocusRequested(value: int -> unit) = x.WithAttribute(ViewAttributes.AutoFocusRequestedAttribKey, (fun f -> System.EventHandler<int>(fun _sender _args -> f _args))(value))

        /// Adjusts the IsScanning property in the visual element
        member x.IsScanning(value: bool) = x.WithAttribute(ViewAttributes.IsScanningAttribKey, (value))

        /// Adjusts the IsTorchOn property in the visual element
        member x.IsTorchOn(value: bool) = x.WithAttribute(ViewAttributes.IsTorchOnAttribKey, (value))

        /// Adjusts the IsAnalyzing property in the visual element
        member x.IsAnalyzing(value: bool) = x.WithAttribute(ViewAttributes.IsAnalyzingAttribKey, (value))

        /// Adjusts the Result property in the visual element
        member x.Result(value: ZXing.Result) = x.WithAttribute(ViewAttributes.ResultAttribKey, (value))

        /// Adjusts the ScanResultCommand property in the visual element
        member x.ScanResultCommand(value: unit -> unit) = x.WithAttribute(ViewAttributes.ScanResultCommandAttribKey, (value))

        /// Adjusts the ScanResultCommandCanExecute property in the visual element
        member x.ScanResultCommandCanExecute(value: bool) = x.WithAttribute(ViewAttributes.ScanResultCommandCanExecuteAttribKey, (value))

        member inline viewElement.With(?onScanResult: unit -> unit, ?autoFocusRequested: int -> unit, ?isScanning: bool, ?isTorchOn: bool, ?isAnalyzing: bool, 
                                       ?result: ZXing.Result, ?scanResultCommand: unit -> unit, ?scanResultCommandCanExecute: bool) =
            let viewElement = match onScanResult with None -> viewElement | Some opt -> viewElement.OnScanResult(opt)
            let viewElement = match autoFocusRequested with None -> viewElement | Some opt -> viewElement.AutoFocusRequested(opt)
            let viewElement = match isScanning with None -> viewElement | Some opt -> viewElement.IsScanning(opt)
            let viewElement = match isTorchOn with None -> viewElement | Some opt -> viewElement.IsTorchOn(opt)
            let viewElement = match isAnalyzing with None -> viewElement | Some opt -> viewElement.IsAnalyzing(opt)
            let viewElement = match result with None -> viewElement | Some opt -> viewElement.Result(opt)
            let viewElement = match scanResultCommand with None -> viewElement | Some opt -> viewElement.ScanResultCommand(opt)
            let viewElement = match scanResultCommandCanExecute with None -> viewElement | Some opt -> viewElement.ScanResultCommandCanExecute(opt)
            viewElement

    /// Adjusts the OnScanResult property in the visual element
    let onScanResult (value: unit -> unit) (x: ViewElement) = x.OnScanResult(value)
    /// Adjusts the AutoFocusRequested property in the visual element
    let autoFocusRequested (value: int -> unit) (x: ViewElement) = x.AutoFocusRequested(value)
    /// Adjusts the IsScanning property in the visual element
    let isScanning (value: bool) (x: ViewElement) = x.IsScanning(value)
    /// Adjusts the IsTorchOn property in the visual element
    let isTorchOn (value: bool) (x: ViewElement) = x.IsTorchOn(value)
    /// Adjusts the IsAnalyzing property in the visual element
    let isAnalyzing (value: bool) (x: ViewElement) = x.IsAnalyzing(value)
    /// Adjusts the Result property in the visual element
    let result (value: ZXing.Result) (x: ViewElement) = x.Result(value)
    /// Adjusts the ScanResultCommand property in the visual element
    let scanResultCommand (value: unit -> unit) (x: ViewElement) = x.ScanResultCommand(value)
    /// Adjusts the ScanResultCommandCanExecute property in the visual element
    let scanResultCommandCanExecute (value: bool) (x: ViewElement) = x.ScanResultCommandCanExecute(value)
