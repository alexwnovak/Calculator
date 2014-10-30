using System;

namespace Calc
{
   public class ConstantExpression : IExpression
   {
      private int _value;

      public void Print()
      {
         Console.Write( _value.ToString() );
      }
   }
}
