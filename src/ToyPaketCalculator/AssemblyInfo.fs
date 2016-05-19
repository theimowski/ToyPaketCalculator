namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ToyPaketCalculator")>]
[<assembly: AssemblyProductAttribute("ToyPaketCalculator")>]
[<assembly: AssemblyDescriptionAttribute("Toy Calculator project in F# for the purpose of demonstating paket.local feature")>]
[<assembly: AssemblyVersionAttribute("0.0.1")>]
[<assembly: AssemblyFileVersionAttribute("0.0.1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.1"
    let [<Literal>] InformationalVersion = "0.0.1"
