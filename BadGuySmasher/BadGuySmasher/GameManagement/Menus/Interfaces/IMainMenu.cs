﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadGuySmasher.GameManagement.Menus.Interfaces
{
  public interface IMainMenu
  {
    int NumberOfPlayers { get; }

    void           Draw();
    MainMenu.State UpdateInput();
  }
}
