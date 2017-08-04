module Jaran

open System

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import

type Something =
    { lastuser : string
      lastactive : int64 }

let u = """ { "lastuser": "Administrator", "lastactive": 636372711333291008 } """

let init() =
    // Browser.console.debug (sprintf "this : %A" <| ofJson<Something> u)
    let a : Something = ofJson u
    // Browser.console.debug (sprintf "this : %A" <| ofJson u)
    Browser.console.debug (sprintf "lastuser : %s" a.lastuser)
    Browser.console.debug (sprintf "lastuser : %A" a.lastactive)
    let canvas = Browser.document.getElementsByTagName_canvas().[0]
    canvas.width <- 1000.
    canvas.height <- 800.
    let ctx = canvas.getContext_2d()
    // The (!^) operator checks and casts a value to an Erased Union type
    // See http://fable.io/docs/interacting.html#Erase-attribute
    ctx.fillStyle <- !^"rgb(200,0,0)"
    ctx.fillRect (10., 10., 55., 50.)
    ctx.fillStyle <- !^"rgba(0, 0, 200, 0.5)"
    ctx.fillRect (30., 30., 55., 50.)

init()