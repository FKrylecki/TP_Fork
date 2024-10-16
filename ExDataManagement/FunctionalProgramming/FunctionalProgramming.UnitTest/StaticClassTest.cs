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
using TP.FunctionalProgramming;

namespace TP.ExDM.FunctionalProgramming
{
  [TestClass]
  public class StaticClassTest
  {
    // public StaticClass staticClassVariable; //Cannot declare a variable of static type 'StaticClass'

    [TestMethod]
    public void StaticClassTestMethod()
    {
      #region Implicit constructor call

      Assert.AreEqual(123456.789, StaticClass.MinIncome);
      Assert.AreEqual(987654.321, StaticClass.MaxIncome);

      #endregion Implicit constructor call

      #region state behavior

      StaticClass.StaticClassInitializer(3.0, 1.0); //Invocation of a static method from static class
      Assert.AreEqual(1.0, StaticClass.MinIncome);
      Assert.AreEqual(3.0, StaticClass.MaxIncome);
      Assert.AreEqual(2.0, StaticClass.AverageIncome);

      #endregion state behavior
    }
  }
}