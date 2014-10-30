namespace Calc
{
   public abstract class UnaryExpression : IExpression
   {
      private readonly IExpression _expression;
      protected IExpression Expression
      {
         get { return _expression; }
      }

      public abstract void Print();
   }
}
