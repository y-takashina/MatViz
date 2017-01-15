# Matrix Visualizer

Simple C# API for matrix(2d array) visualization.

```csharp
public static void SaveMatrixImage(double[,] matrix, string name, double threshold = double.MaxValue, bool bgWhite = true)
```

## Parameters
- matrix: The matrix you want to visualize
- name: File name of the image
- threshold: Dynamic range for the matrix values
- bgWhite: As default, zero will be drawn white and max value will be black. If set to false, the color will be flipped.

## How to use
You can install MatViz via NuGet package manager.<br>
The NuGet id of this package is `MatViz.dll`, not `MatViz`.

[NuGet page for MatViz](https://www.nuget.org/packages/MatViz.dll/1.0.1.1)

If you want to edit source code, add this project to your solution as a sub project, or simply download the .cs file and modify namespace to your project.

## Examples
| matrix | query|  image |
|---|---|---|
| {{0.0, 0.3, 0.5, 0.8, 1},<br> {0, 0, 0, 0, 0}} | SaveMatrixImage(matrix, name, double.MaxValue, true) | <img src="image/positive.png" width="400"> |
| {{0.0, 0.3, 0.5, 0.8, 1},<br> {0, 0, 0, 0, 0}} | SaveMatrixImage(matrix, name, double.MaxValue, false) | <img src="image/positive-flipped.png" width="400"> |
| {{0.0, 0.3, 0.5, 0.8, 1},<br> {0.0, -0.3, -0.5, -0.8, -1}} | SaveMatrixImage(matrix, name, double.MaxValue, true) |<img src="image/negative.png" width="400"> |
| {{0.0, 0.3, 0.5, 0.8, 1},<br> {0.0, -0.3, -0.5, -0.8, -1}} | SaveMatrixImage(matrix, name, double.MaxValue, false) |<img src="image/negative-flipped.png" width="400"> |
| {{0.0, 0.3, 0.5, 0.8, 1},<br> {0.0, -0.3, -0.5, -0.8, -1}} | SaveMatrixImage(matrix, name, 0.5, true) |<img src="image/negative-threshold.png" width="400"> |
| {{0.0, 0.3, 0.5, 0.8, 1},<br> {0.0, -0.3, -0.5, -0.8, -1}} | SaveMatrixImage(matrix, name, 0.5, false) |<img src="image/negative-flipped-threshold.png" width="400"> |


