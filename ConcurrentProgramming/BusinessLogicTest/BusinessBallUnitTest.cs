﻿//____________________________________________________________________________________________________________________________________
//
//  Copyright (C) 2024, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community by pressing the `Watch` button and get started commenting using the discussion panel at
//
//  https://github.com/mpostol/TP/discussions/182
//
//_____________________________________________________________________________________________________________________________________

namespace TP.ConcurrentProgramming.BusinessLogic.Test
{
  [TestClass]
  public class BallUnitTest
  {
    [TestMethod]
    public void MoveTestMethod()
    {
      Position initialPosition = new(10.0, 10.0);
      Ball newInstance = new(initialPosition);
      IPosition curentPosition = new Position(0.0, 0.0);
      int numberOfCallBackCalled = 0;
      newInstance.NewPositionNotification += (sender, position) => { Assert.IsNotNull(sender); curentPosition = position; numberOfCallBackCalled++; };
      newInstance.Move(new Position(0.0, 0.0));
      Assert.AreEqual<int>(1, numberOfCallBackCalled);
      Assert.AreEqual<IPosition>(initialPosition, curentPosition);
    }
  }
}