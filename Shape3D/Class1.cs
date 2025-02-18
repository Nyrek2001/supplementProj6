using System;

/// <summary>
/// Abstract base class representing a 3D shape.
/// </summary>
public abstract class Shape3D
{
    /// <summary>
    /// Calculates the volume of the shape.
    /// </summary>
    public abstract double GetVolume();

    /// <summary>
    /// Calculates the surface area of the shape.
    /// </summary>
    public abstract double GetSurfaceArea();

    /// <summary>
    /// Returns a string identifying the shape, surface area, and volume.
    /// </summary>
    public abstract string Dump();
}

/// <summary>
/// Represents a cube.
/// </summary>
public class Cube : Shape3D
{
    private double side;

    public Cube(double side)
    {
        Validate(side);
        this.side = side;
    }

    private void Validate(double side)
    {
        if (side <= 0)
            throw new ArgumentException("Side length must be greater than zero.");
    }

    public override double GetVolume() => Math.Pow(side, 3);

    public override double GetSurfaceArea() => 6 * Math.Pow(side, 2);

    public override string Dump() =>
        $"Cube: Surface Area = {GetSurfaceArea()}, Volume = {GetVolume()}";
}


public class Sphere : Shape3D
{
    private double radius;

    public Sphere(double radius)
    {
        Validate(radius);
        this.radius = radius;
    }

    private void Validate(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be greater than zero.");
    }

    public override double GetVolume() => (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

    public override double GetSurfaceArea() => 4 * Math.PI * Math.Pow(radius, 2);

    public override string Dump() =>
        $"Sphere: Surface Area = {GetSurfaceArea():F3}, Volume = {GetVolume():F3}";
}

public class Cylinder : Shape3D
{
    private double radius;
    private double height;

    public Cylinder(double radius, double height)
    {
        Validate(radius, height);
        this.radius = radius;
        this.height = height;
    }

    private void Validate(double radius, double height)
    {
        if (radius <= 0 || height <= 0)
            throw new ArgumentException("Radius and height must be greater than zero.");
    }

    public override double GetVolume() => Math.PI * Math.Pow(radius, 2) * height;

    public override double GetSurfaceArea() =>
        2 * Math.PI * radius * (radius + height);

    public override string Dump() =>
        $"Cylinder: Surface Area = {GetSurfaceArea():F3}, Volume = {GetVolume():F3}";
}

