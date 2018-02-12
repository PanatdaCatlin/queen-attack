using System;
using System.Text;

namespace QueenAttack
{
  public class Queen
  {
    int _xValue;
    int _yValue;

    public Queen(string x, string y)
    {
      _xValue = int.Parse(x);
      _yValue = int.Parse(y);
    }

    public bool InputCheck(string x, string y)
    {
      bool XIsNumeric = int.TryParse(x, out int a);
      bool YIsNumeric = int.TryParse(y, out int b);
      if (XIsNumeric && YIsNumeric)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool HorizontalAttack(string TargetX, string TargetY)
    {
      if (int.Parse(TargetY) == _yValue)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool VerticalAttack(string TargetX, string TargetY)
    {
      if (int.Parse(TargetX) == _xValue)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool DiagonalAttack(string TargetX, string TargetY)
    {
      if (Math.Abs(_xValue - int.Parse(TargetX)) == Math.Abs(_yValue - int.Parse(TargetY)))
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
