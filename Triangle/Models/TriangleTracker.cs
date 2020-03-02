namespace Triangle
{
  public class TriangleTracker
  {
    public bool SideCheck(string inputNumber)
    {
      int side;
      bool success = int.TryParse(inputNumber, out side);
      if (success)
      {
        return true;
      }
      return false;
    }
    public bool IsTri(int side1, int side2, int side3)
    {
      if(side1 >= side2 + side3 || side2 >= side3 + side1 || side3 >= side1 + side2)
      {
        return false;
      }
      else if(side1 == side2 && side2 == side3 && side3 == side1)
      {
        return true;
      }
      else if (side1 == side2 || side1 == side3 || side2 == side3)
      {
        return true;
      } 
      else if(side1 != side2 || side1 != side3 || side2 != side3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}