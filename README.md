# Matrix Visualizer

Very simple C# API for matrix visualization.

```csharp
public static void SaveMatrixImage(double[,] matrix, string name, double threshold = double.MaxValue, bool bgWhite = true)
```

## parameter
- matrix: The matrix you want to visualize
- name: File name of the image
- threshold: Dynamic range for the matrix values
- bgWhite: As default, zero will be drawn white and max value will be black. If set to false, the color will be flipped.


| matrix | image |
|---|---|
| {{0.0, 0.3, 0.5, 0.8, 1},<br> {0, 0, 0, 0, 0}} | <img src="image/positive.png" width="400"> |
| {{0.0, 0.3, 0.5, 0.8, 1},<br> {0, 0, 0, 0, 0}} | <img src="image/positive-flipped.png" width="400"> |
| {{0.0, 0.3, 0.5, 0.8, 1},<br> {0.0, -0.3, -0.5, -0.8, -1}} | <img src="image/negative.png" width="400"> |
| {{0.0, 0.3, 0.5, 0.8, 1},<br> {0.0, -0.3, -0.5, -0.8, -1}} | <img src="image/negative-flipped.png" width="400"> |

