using System;
using System.Collections.Generic;

class GameState
{
  public int Level { get; }
  public int Health { get; }
  public string Position { get; }

  public GameState(int level, int health, string position)
  {
    Level = level;
    Health = health;
    Position = position;
  }
}

class Game
{
  public int Level { get; set; }
  public int Health { get; set; }
  public string Position { get; set; }

  public GameState Save() => new GameState(Level, Health, Position);

  public void Restore(GameState state)
  {
    Level = state.Level;
    Health = state.Health;
    Position = state.Position;
  }

  public void ShowState()
  {
    Console.WriteLine($"Cấp độ: {Level}, Máu: {Health}, Vị trí: {Position}");
  }
}

class GameHistory
{
  private Stack<GameState> history = new Stack<GameState>();

  public void Save(GameState state) => history.Push(state);

  public GameState? Undo() => history.Count > 0 ? history.Pop() : null;
}