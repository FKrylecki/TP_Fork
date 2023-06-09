﻿//____________________________________________________________________________________________________________________________________
//
//  Copyright (C) 2023, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community by pressing the `Watch` button and get started commenting using the discussion panel at
//
//  https://github.com/mpostol/TP/discussions/182
//
//  by introducing yourself and telling us what you do with this community.
//_____________________________________________________________________________________________________________________________________

using System.Collections.Generic;
using TP.GraphicalData.Model.API;

namespace TP.GraphicalData.Model.IMP
{
  internal class DataLayer : DataLayerAPI
  {
    public IEnumerable<IUser> Users
    {
      get
      {
        List<IUser> Users = new List<IUser>()
                {
                    new User() { Age = 21, Name = "Jan", Active = true },
                    new User() { Age = 22, Name = "Stefan", Active = false }
                };
        return Users;
      }
    }
  }
}