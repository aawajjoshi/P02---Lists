# P02 MVC App - Lists


## About the application

The app Lists maintains a list of names. It is an interactive app that requires user interaction. 

## Built With 

The language implemented is **C#**. **Visual Studio** was used to edit the code.

## Changes made as per the instructions

**Expand the Home Controller**

```
 public IActionResult Names()
        {
            return View();
        }

```

**Add a new View**

A new view named Names.cshtml was added. 

```
@{
    ViewData["Title"] = "Names";
    ViewData["Message"] = "Here are the names";
}
<h1>@ViewData["Title"]</h1>

<p>@ViewData["Message"]</p>
```

**Add a new Controller**

A new controller named ListController.cs was created. The necessary methods were implemented as the per the instructions.


## Screenshots of an app run 

![screenshot2](https://user-images.githubusercontent.com/31771293/52508269-9af1e900-2bb9-11e9-98f2-d3a61040c5fb.png)

![screenshot1](https://user-images.githubusercontent.com/31771293/52508268-9af1e900-2bb9-11e9-8396-8f74a3b7f0c9.png)

## Test

The test implemented assesses the multiplied product of two positive integers.

```
public void Multiply_WorksWithTwoPositiveIntegers()
        {
            var expected = 4;
            var a = 2;
            var b = 2; 
            var actual = multiply(a, b);
            Assert.Equal(expected,actual);
        }
```

## Author
Aawaj Raj Joshi
