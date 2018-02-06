module Tests

open System
open System.IO
open Xunit
open Swensen.Unquote

let getCredentialsPath () =
    let personal = 
        Environment.SpecialFolder.Personal
    Path.Combine(
        Environment.GetFolderPath(personal),
        ".credentials/blobtocsv.json")
[<Fact>]
[<Trait("Category", "Integration")>]
let ``where is personal dir`` () =
    getCredentialsPath () 
    =! @"/home/mika/.credentials/blobtocsv.json"
