namespace ScreenSound.Modelos;

class Banda
{
    private List<Album> _albuns = [];
    private List<int> _notas = [];
    public Banda(string nome)
    {
        this.Nome = nome;
    }
    public string Nome { get; }
    public double Media => _notas.Average();
    public List<Album> Albuns => _albuns;
    public List<int> Notas => _notas;

    public void AddAlbum(Album album)
    {
        _albuns.Add(album);
    }

    public void AddNota(int nota)
    {
        _notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in _albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }

    }
}