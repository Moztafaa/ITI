// 1
interface one { name: string, age: number }

let oneObj: Partial<one> = {
    name: "Mostafa"
}

// ------------------------------------------------------
// 2
interface IProfile { username?: string, email?: string }

let profileObj: Required<IProfile> = {
    username: "Moztafa",
    email: "xyz"
}

// ------------------------------------------------------
// 3
type Color = "red" | "green" | "blue"
type ColorHex = Record<Color, string>

let hexObj: ColorHex = {
    red: "#000000",
    green: "#111111",
    blue: "#ffffff"
}
// console.log(hexObj.red);

// ------------------------------------------------------
// 4
interface IPerson { name: string, age: number, email: string }
type PersonWithOnlyNameAndEmail = Pick<IPerson, "name" | "email">
let test4: PersonWithOnlyNameAndEmail = {
    name: "Mostafa",
    email: "xyz"
}

// ------------------------------------------------------
// 5

type PersonWithoutAge = Omit<IPerson, "age">

let test5: PersonWithoutAge = {
    name: "Mostafa",
    email: "xyz"
}

// ------------------------------------------------------
// 6
type ColorsWithYellow = "red" | "green" | "blue" | "yellow"
type ColorsWithoutYellow = Exclude<ColorsWithYellow, "yellow">

let test6: ColorsWithoutYellow = "green"

// ------------------------------------------------------
// 7
type ColorWithOnlyRedAndBlue = Extract<ColorsWithYellow, "red" | "blue">

let test7: ColorWithOnlyRedAndBlue = "blue"

// ------------------------------------------------------
// 8
type MaybeString = string | null | undefined

type WithoutNullOrUndefined = Extract<MaybeString, string>
let test8: WithoutNullOrUndefined = "s"

type MaybeStringWithoutNullable = NonNullable<MaybeString>
let test8v2: MaybeStringWithoutNullable = "s"




