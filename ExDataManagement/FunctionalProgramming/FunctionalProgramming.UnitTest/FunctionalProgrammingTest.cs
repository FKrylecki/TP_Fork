//____________________________________________________________________________________________________________________________________
//
//  Copyright (C) 2024, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community by pressing the `Watch` button and get started commenting using the discussion panel at
//
//  https://github.com/mpostol/TP/discussions/182
//
//_____________________________________________________________________________________________________________________________________

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TP.FunctionalProgramming
{
  //public TP.FunctionalProgramming.FunctionalProgramming variable; //Error CS0723  Cannot declare a variable of static type 'FunctionalProgramming'

  /// <summary>
  /// Demonstrates usage of the <seealso cref="FunctionalProgramming.StringIsLongPredicate"/>.
  /// </summary>
  /// <remarks>
  /// The function result depends only on the value passed as the argument.
  /// </remarks>
  [TestClass]
  public class FunctionalProgrammingTest
  {
    [TestMethod]
    public void StringIsLongPredicateTest()
    {
      Assert.IsTrue(FunctionalProgramming.StringIsLongPredicate("g5F|z*tC&yKJU$"));
      Assert.IsFalse(FunctionalProgramming.StringIsLongPredicate("g5F|z"));
    }
  }
}