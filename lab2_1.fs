open System

let rec CreateList InputList =
    printfn "Введите целое число для добавления в список: "
    let inputLine = Console.ReadLine()
    if (inputLine <> "") then 
        match System.Int32.TryParse(inputLine) with
        | (true, conInt) -> CreateList (InputList @ [conInt])
        | _ -> 
            printfn "Ошибка, повторите ввод"
            CreateList InputList
    else InputList
let AbsoluteInt X =
    if (X<0) then 
        -X
    else 
        X

let rec FirstNum X =
    let Y = AbsoluteInt X
    if ((Y/10)=0) then 
        Y
    else 
        FirstNum (Y/10)
[<EntryPoint>]
let main args =
    printfn "Создание изначального списка"
    printfn "Введите пустую строку для конца"
    let aList = CreateList [] 
    let bList = List.map FirstNum aList

    printfn "Итоговый список из первых цифр: %A" bList
    0
