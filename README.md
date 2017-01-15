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

<table>
    <th>matrix</th><th>image</th>
    <tr>
        <td>{{0.0, 0.3, 0.5, 0.8, 1}, {0, 0, 0, 0, 0}}</td>
        <td>![positive](image/positive.png)</td>
    </tr>
    <tr>
        <td>{{0.0, 0.3, 0.5, 0.8, 1}, {0, 0, 0, 0, 0}}</td>
        <td>![positive-flipped](image/positive-flipped.png)</td>
    </tr>
    <tr>
        <td>{{0.0, 0.3, 0.5, 0.8, 1}, {0.0, -0.3, -0.5, -0.8, -1}}</td>
        <td>![negative](image/negative.png)</td>
    </tr>
    <tr>
        <td>{{0.0, 0.3, 0.5, 0.8, 1}, {0.0, -0.3, -0.5, -0.8, -1}}</td>
        <td>![negative-flipped](image/negative-flipped.png)</td>
    </tr>
</table>

