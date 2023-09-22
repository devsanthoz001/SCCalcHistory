# SCCalcHistory
TDD for calculator history


how to run a specific test?

 dotnet test --filter "FullyQualifiedName=ComputerTest.CalculatorHistoryTests.CheckLongHistoryTest"

how to run UI project?
dotnet run --project ComputerUI/ComputerUI.csproj 

 /*
        CurrentKeyPress  RunningTotal    Equation       LastPressedKey
        1                   1            1       
        2                   12           12      
        +                   12           12+
        3                   3            12+3    
        4                   34           23+34
        -                   57           57-
        2                   57           57-2
        7                   57           57-27
        =                   30
        */