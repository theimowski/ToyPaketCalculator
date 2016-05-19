module ToyPaketCalculator.Tests

open ToyPaketCalculator
open NUnit.Framework

[<Test>]
let ``add 5 and 3 returns 8`` () =
  let result = Calculator.add 5 3
  printfn "%i" result
  Assert.AreEqual(8,result)
