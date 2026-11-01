using System.Text;

Console.OutputEncoding = Encoding.UTF8;

SportsTeam[] teams =
{
    new FootballTeam("Динамо", "Олександр Шовковський", 2),
    new BasketballTeam("Київ-Баскет", "Дмитро Забірченко", 4),
    new HockeyTeam("Сокіл", "Олег Шафаренко", 1)
};


foreach (SportsTeam team in teams)
{
    team.ShowInfo();
    team.PlayGame();
    Console.WriteLine();
}

class SportsTeam
{
    protected string teamName;
    protected string coach;
    protected int ranking;

    public string TeamName
    {
        get { return teamName; }
        set { teamName = value; }
    }

    public string Coach
    {
        get { return coach; }
        set { coach = value; }
    }

    public int Ranking
    {
        get { return ranking; }
        set { ranking = value; }
    }

    public SportsTeam(string teamName, string coach, int ranking)
    {
        this.teamName = teamName;
        this.coach = coach;
        this.ranking = ranking;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Команда: {TeamName}");
        Console.WriteLine($"Тренер: {Coach}");
        Console.WriteLine($"Місце в рейтингу: {Ranking}");
    }

    public virtual void PlayGame()
    {
        Console.WriteLine("Команда бере участь у спортивній грі.");
    }
}

class FootballTeam : SportsTeam
{
    public FootballTeam(string teamName, string coach, int ranking)
        : base(teamName, coach, ranking)
    {
    }

    public override void PlayGame()
    {
        Console.WriteLine("Футбольна команда грає матч на футбольному полі.");
    }
}

class BasketballTeam : SportsTeam
{
    public BasketballTeam(string teamName, string coach, int ranking)
        : base(teamName, coach, ranking)
    {
    }

    public override void PlayGame()
    {
        Console.WriteLine("Баскетбольна команда грає матч у спортивному залі.");
    }
}

class HockeyTeam : SportsTeam
{
    public HockeyTeam(string teamName, string coach, int ranking)
        : base(teamName, coach, ranking)
    {
    }

    public override void PlayGame()
    {
        Console.WriteLine("Хокейна команда грає матч на льодовій арені.");
    }
}
