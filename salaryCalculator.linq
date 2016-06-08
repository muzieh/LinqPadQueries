<Query Kind="FSharpProgram" />

let baseSalary = 60000
let days = 365
let workingDays = 253
let holidays = 25
let publicHolidays = 8
let sickLeave = 7
let sumOfHolidays = holidays + publicHolidays + sickLeave
let daysAtWork = workingDays - sumOfHolidays

let perMonth = baseSalary / 12
let perWorkingDay = baseSalary / daysAtWork 
perWorkingDay.Dump()
printfn "%A" perMonth

