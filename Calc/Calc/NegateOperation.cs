namespace Calc
{
   public class NegateOperation : UnaryExpression
   {
      public NegateOperation( IExpression expression )
         : base( expression )
      {
      }

      public override void Print()
      {
         throw new System.NotImplementedException();
      }
   }
}
