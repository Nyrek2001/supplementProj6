public class ShapeContainer
{
    private List<Shape3D> shapes = new List<Shape3D>();

    public void Create(Shape3D shape)
    {
        shapes.Add(shape);
    }

    public Shape3D Get(int index)
    {
        if (index < 0 || index >= shapes.Count)
            throw new IndexOutOfRangeException("Invalid index.");
        return shapes[index];
    }

    public void Delete(int index)
    {
        if (index < 0 || index >= shapes.Count)
            throw new IndexOutOfRangeException("Invalid index.");
        shapes.RemoveAt(index);
    }
}
