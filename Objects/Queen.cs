using System;
using System.Collections;

namespace QueenAttack.Objects
{
  public class Queen
  {
    private int _xCoordinate;
    private int _yCoordinate;

    public Queen (int newXCoordinate, int newYCoordinate)
    {
      _xCoordinate = newXCoordinate;
      _yCoordinate = newYCoordinate;
    }

    public void SetX(int coordinate)
    {
      _xCoordinate = coordinate;
    }
    public int GetX()
    {
      return _xCoordinate;
    }

    public void SetY(int coordinate)
    {
      _yCoordinate = coordinate;
    }
    public int GetY()
    {
      return _yCoordinate;
    }

    public bool CanAttack(int targetX, int targetY)
    {
      bool onSameAxis = targetX == _xCoordinate || targetY == _yCoordinate;
      bool onFortyFiveDiagonal = Math.Abs(targetX - _xCoordinate) == Math.Abs(targetY - _yCoordinate);

      if (onSameAxis)
      {
        return true;
      }
      else if (onFortyFiveDiagonal)
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
