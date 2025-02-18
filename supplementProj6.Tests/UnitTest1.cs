
public class UnitTest1
{
  [Fact]
public void Cube_GetVolume_CorrectResult()
{
    var cube = new Cube(3);
    Assert.Equal(27, cube.GetVolume());
}  
}

