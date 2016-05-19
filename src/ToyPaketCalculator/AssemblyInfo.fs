namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ToyPaketCalculator")>]
[<assembly: AssemblyProductAttribute("ToyPaketCalculator")>]
[<assembly: AssemblyDescriptionAttribute("Toy Calculator project in F# for the purpose of demonstating paket.local feature")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
    let [<Literal>] InformationalVersion = "1.0"
