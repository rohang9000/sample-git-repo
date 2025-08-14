open Amazon.CDK
open MyCdkApp

[<EntryPoint>]
let main argv =
    let app = App()
    MyCdkAppStack(app, "MyCdkAppStack") |> ignore
    app.Synth() |> ignore
    0