namespace AdventOfCode2022.Week01
{
  internal class Day02
  {
    public Player Opponent = new();
    public Player You = new();
    public List<Winner> DesiredOutcomes = new();
    public Day02(string[] input)
    {
      foreach (var line in input)
      {
        var parts = line.ToCharArray();
        Opponent.Moves.Add(GetOpponentMove(parts[0]));
        You.Moves.Add(GetYourMove(parts[2]));
        DesiredOutcomes.Add(GetDesiredOutcome(parts[2]));
      }
    }

    private Winner GetDesiredOutcome(char c)
    {
      switch (c)
      {
        case 'X':
          return Winner.Opponent;
        case 'Y':
          return Winner.Draw;
        case 'Z':
          return Winner.You;
        default:
          throw new InvalidDataException("The input character is not supported (GetDesiredOutcome)");
      }
    }

    private Move GetYourMove(char c)
    {
      switch (c)
      {
        case 'X':
          return Move.Rock;
        case 'Y':
          return Move.Paper;
        case 'Z':
          return Move.Scissor;
        default:
          throw new InvalidDataException("The input character is not supported (GetYourMove)");
      }
    }

    private Move GetOpponentMove(char c)
    {
      switch (c)
      {
        case 'A':
          return Move.Rock;
        case 'B':
          return Move.Paper;
        case 'C':
          return Move.Scissor;
        default:
          throw new InvalidDataException("The input character is not supported (GetOpponentMove)");
      }
    }

    internal int GetTotalScoreWithDesiredOutcome()
    {
      var score = 0;
      for (int i = 0; i < Opponent.Moves.Count; i++)
      {
        var winner = DesiredOutcomes[i];
        var scoreFromWinner = DetermineScoreFromWinner(winner);
        Move yourMove = DetermineMoveBasedOnWinner(Opponent.Moves[i], winner);
        var scoreFromMove = DetermineScoreFromMove(yourMove);
        score += scoreFromWinner + scoreFromMove;
      }
      return score;
    }

    private Move DetermineMoveBasedOnWinner(Move move, Winner winner)
    {
      switch (move)
      {
        case Move.Rock:
          if (winner == Winner.Draw) return Move.Rock;
          if (winner == Winner.Opponent) return Move.Scissor;
          if (winner == Winner.You) return Move.Paper;
          throw new Exception("Why are you here!?");
        case Move.Paper:
          if (winner == Winner.Draw) return Move.Paper;
          if (winner == Winner.Opponent) return Move.Rock;
          if (winner == Winner.You) return Move.Scissor;
          throw new Exception("Why are you here!?");
        case Move.Scissor:
          if (winner == Winner.Draw) return Move.Scissor;
          if (winner == Winner.Opponent) return Move.Paper;
          if (winner == Winner.You) return Move.Rock;
          throw new Exception("Why are you here!?");
        default:
          throw new Exception("Unsupported Move!");
      }
    }

    internal int GetTotalScore()
    {
      var score = 0;
      for (int i = 0; i < Opponent.Moves.Count; i++)
      {
        var winner = DetermineWinnerForIndex(i);
        var scoreFromWinner = DetermineScoreFromWinner(winner);
        var scoreFromSelection = DetermineScoreFromMove(You.Moves[i]);
        score += scoreFromWinner + scoreFromSelection;
      }
      return score;
    }

    private int DetermineScoreFromMove(Move move)
    {
      switch (move)
      {
        case Move.Rock:
          return 1;
        case Move.Paper:
          return 2;
        case Move.Scissor:
          return 3;
        default:
          throw new Exception("Unsupported Move!");
      }
    }

    private int DetermineScoreFromWinner(Winner winner)
    {
      switch (winner)
      {
        case Winner.Opponent:
          return 0;
        case Winner.Draw:
          return 3;
        case Winner.You:
          return 6;
        default:
          throw new Exception("Unsupported Winner Type");
      }
    }

    private Winner DetermineWinnerForIndex(int index)
    {
      var opponentMove = Opponent.Moves[index];
      var yourMove = You.Moves[index];

      if (opponentMove == yourMove) return Winner.Draw;

      switch (opponentMove)
      {
        case Move.Rock:
          if (yourMove == Move.Paper) return Winner.You;
          else return Winner.Opponent;
        case Move.Paper:
          if (yourMove == Move.Rock) return Winner.Opponent;
          else return Winner.You;
        case Move.Scissor:
          if (yourMove == Move.Rock) return Winner.You;
          else return Winner.Opponent;
        default:
          throw new Exception("Unsupported move combination");
      }
    }


    internal class Player
    {
      public List<Move> Moves = new List<Move>();
    }

    internal enum Winner
    {
      Opponent,
      You,
      Draw
    }

    internal enum Move
    {
      Rock,
      Paper,
      Scissor
    }
  }
}
