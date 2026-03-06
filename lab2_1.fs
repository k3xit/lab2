open System

let rec createList inputList =
    printfn "Введите целое число для добавления в список: "
    let inputLine = Console.ReadLine()
    if (inputLine <> "") then 
        match System.Int32.TryParse(inputLine) with
        | (true, conInt) -> createList (inputList @ [conInt])
        | _ -> 
            printfn "Ошибка, повторите ввод"
            createList inputList
    else 
        inputList
let absoluteInt X =
    if (X<0) then 
        -X
    else 
        X

let rec firstNum X =
    let Y = absoluteInt X
    if ((Y/10)=0) then 
        Y
    else 
        firstNum (Y/10)
[<EntryPoint>]
let main args =
    printfn "Создание изначального списка"
    printfn "Введите пустую строку для конца"
    let aList = createList [] 
    printfn "Изначальный список: %A" aList
    let bList = List.map firstNum aList
    printfn "Итоговый список из первых цифр: %A" bList
    0
