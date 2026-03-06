open System

let rec inputInt () = 
    printf "Введите целое число для поиска: "
    match System.Int32.TryParse(Console.ReadLine()) with
    | true, convertInt -> convertInt
    | _ -> 
        printfn "Ошибка, повторите ввод"
        inputInt ()

let rec createList inputList =
    printfn "Введите целое число для добавления в список: "
    let inputLine = Console.ReadLine()
    if inputLine <> "" then 
        match System.Int32.TryParse(inputLine) with
        | true, conInt -> createList (inputList @ [conInt])
        | _ -> 
            printfn "Ошибка, повторите ввод"
            createList inputList
    else inputList

let matchNumber elem X =
    if (elem=X) then 
        1
    else 
        0

[<EntryPoint>]

let main args =
    printfn "Создание списка"
    printfn "Введите пустую строку для конца"
    let aList = createList [] 
    printfn "Готовый список: %A" aList
    let a = inputInt ()
    let b = List.fold (fun acc elem -> 
                            if elem=a then
                                acc+1
                            else
                                acc
                        ) 0 aList
    printfn "Количество совпадений: %i" b
    0
