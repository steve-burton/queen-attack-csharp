using Xunit;
using QueenAttack.Objects;

namespace QueenAttack
{
  public class QueenAttackTest
  {
    [Fact]
    public void CanAttack_SameXCoordinate_true()
    {
      Queen testQueen = new Queen(1, 1);
      Assert.Equal(true, testQueen.CanAttack(1, 3));
    }

    [Fact]
    public void CanAttack_SameYCoordinate_true()
    {
      Queen testQueen = new Queen(3, 2);
      Assert.Equal(true, testQueen.CanAttack(1, 2));
    }

    [Fact]
    public void CanAttack_Diagonal_true()
    {
      Queen testQueen = new Queen(1, 1);
      Assert.Equal(true, testQueen.CanAttack(3, 3));
    }
    [Fact]
    public void CanAttack_Diagonal2_true()
    {
      Queen testQueen = new Queen(1, 1);
      Assert.Equal(true, testQueen.CanAttack(3, 3));
    }

    [Fact]
    public void CanAttack_IllegalMove_false()
    {
      Queen testQueen = new Queen(2, 2);
      Assert.Equal(false, testQueen.CanAttack(3, 4));
    }
  }
}
